using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine;

public class NetShutDownException : ApplicationException
{
    public NetShutDownErrorType ErrorCode;
    public NetShutDownException(string message) : base(message)
    {
       
    }
}

#region 网络错误标识

public enum DownErrorType
{
    None,
    ClientDown,//客户端问题
    ServiceDown//服务器问题
}

public enum NetShutDownErrorType
{
    SocketDown,//套接字未连接
}

#endregion

public class NetSocket : SingletonNet<NetSocket> {



    /// <summary>
    /// 客户端Socket
    /// </summary>
    private Socket m_Client;

    private int m_TimeOutTime;//超时时间

    public bool Connecting;

    public DownErrorType ErrorType;

    #region 发送消息所需参数

    /// <summary>
    /// 发送消息队列
    /// </summary>
    private Queue<byte[]> m_SendQueue = new Queue<byte[]>();

    /// <summary>
    /// 检查队列的委托
    /// </summary>
    private Action m_CheckSendQueue;

    //压缩数组的长度界限
    private const int m_CompressLen = 20000;

    #endregion

    #region 接收消息所需参数

    //接受数据包的缓冲区
    private byte[] m_ReceiveBuffer = new byte[1024];

    //接受数据包的流
    private StreamTool m_ReceiveStream = new StreamTool();

    //接受消息的队列
    private Queue<byte[]> m_ReceiveQueue = new Queue<byte[]>();

    //接受消息的数量
    private int m_ReceiveCount = 0;

    #endregion

    #region 转发协议

    private ushort m_ProtoCode;
    private byte[] m_ProtoContent;

    #endregion

    #region Mono流程

    protected override void OnStart()
    {
        base.OnStart();
    }

    //在update中进行收消息
    protected override void OnUpdate()
    {
        base.OnUpdate();

        //当前处于连接状态才接受消息
        if (m_Client!=null&&m_Client.Connected)
        {
            //从队列种进行消息收取，消息接受超过五条则等待下次Update再读取
            while(true)
            {
                if (m_ReceiveCount<=5)
                {
                    //收到消息后m_ReceiveCount++
                    m_ReceiveCount++;

                    //收消息队列为多线程共享需要锁住
                    lock(m_ReceiveQueue)
                    {
                        if (m_ReceiveQueue.Count>0)
                        {
                            //得到队列中的数据包
                            byte[] buffer = m_ReceiveQueue.Dequeue();

                            //包含数据包体内容的byte[],长度减三是因为包含isCompress与crc的大小
                            byte[] bufferNew = new byte[buffer.Length - 3];

                            //判别是否压缩的变量，已经验证完整性的crc值
                            bool isCompress = false;
                            ushort crc = 0;

                            //将数据包在流中读取，读取压缩变量，crc以及包体内容
                            using (StreamTool streamTool = new StreamTool(buffer))
                            {
                                isCompress = streamTool.ReadBool();
                                crc = streamTool.ReadUShort();
                                streamTool.Read(bufferNew, 0, bufferNew.Length);
                            }

                            //计算crc值
                            int newCrc = Crc16.CalculateCrc16(bufferNew);

                            //比对收到的crc值以验证数据完整性
                            if (crc==newCrc)
                            {
                                //对数据包内容进行异或解密
                                bufferNew = SecurityUtil.Xor(bufferNew);

                                //如果当前为压缩数据则进行解压缩
                                if (isCompress)
                                {
                                    bufferNew = ZlibHelper.DeCompressBytes(bufferNew);
                                }

                                //读取包体内容
                                using (StreamTool streamTool = new StreamTool(bufferNew))
                                {
                                    Debug.Log(streamTool.ReadUTF8String());
                                }
                            }
                            else
                            {
                                //如果数据完整性验证错误，则直接跳过此包
                                break;
                            }
                        }
                    }
                }
                else
                {
                    m_ReceiveCount = 0;
                    break;
                }
            }
        }

        //进行事件分发
        if (m_ProtoCode!=0&&m_ProtoContent!=null)
        {
            EventDispatcher.Instance.Dispatch(m_ProtoCode, m_ProtoContent);
            m_ProtoCode = 0;
            m_ProtoContent = null;
        }
       
    }

    protected override void OnBeforeDestory()
    {
        base.OnBeforeDestory();

        //销毁时关闭Socket
        if (m_Client!=null&&m_Client.Connected)
        {
            m_Client.Shutdown(SocketShutdown.Both);
            m_Client.Close();
        }
    }

    #endregion

    #region 连接服务器

    /// <summary>
    /// 连接Socket服务器
    /// </summary>
    /// <param name="id"></param>
    /// <param name="port"></param>
    public void OnConnect(string id,int port)
    {
        //如果Socket已经存在并且处于连接状态，则直接返回
        if (m_Client!=null&&m_Client.Connected)
        {
            return;
        }
      
        m_Client = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        m_Client.ReceiveTimeout = m_TimeOutTime;
        //进行服务器连接
        try
        {
            CheckNetWork();//判断网络是否通畅
            m_Client.BeginConnect(new IPEndPoint(IPAddress.Parse(SocketHost.IP), SocketHost.Port), ConnectCallBack, m_Client);

        }
        catch(NetShutDownException netEx)
        {
            Debug.Log(netEx.Message);
            this.Connecting = false;
            this.ErrorType = DownErrorType.ClientDown;
        }
        catch(Exception ex)
        {
            Debug.Log("连接失败" + ex.Message);
            this.Connecting = false;
            this.ErrorType = DownErrorType.ServiceDown;
        }
    }

    /// <summary>
    /// 判断网络是否通畅
    /// </summary>
    private void CheckNetWork()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            throw (new NetShutDownException("网络是不通的"));
        }
    }

    //首次Socket连接成功回调
    private void ConnectCallBack(IAsyncResult ar)
    {
        if (m_Client.Connected)
        {
            Debug.Log("Socket连接成功");
            this.Connecting = true;
            this.ErrorType = DownErrorType.None;
            //设置检查队列回调
            m_CheckSendQueue = OnCheckSendQueueCallBack;

            //开始进行消息异步接收
            ReceiveMsg();
        }
        else
        {
            Debug.Log("Socket连接失败，服务器是不通的");
            this.ErrorType = DownErrorType.ServiceDown;
            this.Connecting = false;
        }
        m_Client.EndConnect(ar);
    }
    #endregion

    #region 发送消息相关方法

    /// <summary>
    /// 外部调用发送消息方法
    /// </summary>
    /// <param name="buffer"></param>
    public void SendMsg(byte[] buffer)
    {
        try
        {
            if (!this.Connecting)
            {
                NetShutDownException ex = new NetShutDownException("上次连接套接字失败,需重新连接");
                ex.ErrorCode = NetShutDownErrorType.SocketDown;

                throw (ex);
            }

            CheckNetWork();//判断网络是否通畅
            byte[] sendBuffer = MakeData(buffer);//对数据进行封包处理

            //m_SendQueue为多线程操作 所以锁死
            lock (m_SendQueue)
            {
                //将数据包入队
                m_SendQueue.Enqueue(sendBuffer);

                //检查并启动监视队列委托，在委托中将数据包逐步发送
                if (m_CheckSendQueue == null)
                {
                    return;
                }
                m_CheckSendQueue.BeginInvoke(null, null);
            }
        }
        catch (NetShutDownException netEx)
        {
            Debug.Log(netEx.Message);
            this.Connecting = false;
            this.ErrorType = DownErrorType.ClientDown;
            this.CloseSocket();

            switch (netEx.ErrorCode)
            {
                //套接字重连
                case NetShutDownErrorType.SocketDown:
                    {
                        this.OnConnect(SocketHost.IP, SocketHost.Port);
                    }
                    break;
                default:
                    break;
            }
        }
        

    }

    /// <summary>
    /// 关闭Socket
    /// </summary>
    private void CloseSocket()
    {
        //销毁时关闭Socket
        if (m_Client != null && m_Client.Connected)
        {
            m_Client.Shutdown(SocketShutdown.Both);
            m_Client.Close();
        }
    }

    /// <summary>
    /// 封装数据包 
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    private byte[] MakeData(byte[] data)
    {
        byte[] retBuffer = null;

        //判断是否需要压缩
        bool isCompress = data.Length > m_CompressLen ? true : false;

        //如果需要进行压缩
        if (isCompress)
        {
            data = ZlibHelper.CompressBytes(data);
        }

        //进行异或加密
        data = SecurityUtil.Xor(data);

        //通过Crc校验 得到完整性码
        ushort crc = Crc16.CalculateCrc16(data);

        //使用流
        using (StreamTool stream = new StreamTool())
        {
            //构建数据包

            //数据包头:数据长度
            stream.WriteUShort((ushort)(data.Length + 3));

            //数据包头:是否进行压缩
            stream.WriteBool(isCompress);
            //数据包头:数据完整性码
            stream.WriteUShort(crc);
            //写入包体内容
            stream.Write(data, 0, data.Length);

            retBuffer = stream.ToArray();
        }
        return retBuffer;
    }

    /// <summary>
    /// 发送数据包到服务器
    /// </summary>
    /// <param name="buffer"></param>
    private void Send(byte[] buffer)
    {
        try
        {

            m_Client.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, SendCallBack, m_Client);
        }
        catch (SocketException netEx)
        {
            switch (netEx.ErrorCode)
            {
                case 10057:
                    {
                        Debug.Log("套接字未连接");
                        this.Connecting = false;
                    }
                    break;
                default:
                    break;
            }
          
        }
        catch (Exception ex)
        {
            Debug.Log("发送信息时异常");
         
        }
    }

    /// <summary>
    /// 发送数据包回调
    /// </summary>
    /// <param name="ar"></param>
    private void SendCallBack(IAsyncResult ar)
    {
        //结束此次发送
        m_Client.EndSend(ar);

        //继续下次队列检查
        OnCheckSendQueueCallBack();
    }

    /// <summary>
    /// 接收消息队列检查回调
    /// </summary>
    private void OnCheckSendQueueCallBack()
    {
        //队列为多个线程共享，所以需要加锁
        lock (m_SendQueue)
        {
            //如果队列中有数据包，则发送
            if (m_SendQueue.Count > 0)
            {

                //调用发送数据方法
                Send(m_SendQueue.Dequeue());
            }
        }
    }
    #endregion

    #region 接受消息相关方法

    /// <summary>
    /// 接收数据 连接回调中进行异步调用
    /// </summary>
    private void ReceiveMsg()
    {
        try
        {
            //异步接收数据
            m_Client.BeginReceive(m_ReceiveBuffer, 0, m_ReceiveBuffer.Length, SocketFlags.None, ReceiveCallBack, m_Client);
        }
        catch (Exception ex)
        {
            Debug.Log("发送信息时异常");

        }
     
    }

    /// <summary>
    /// 接收数据回调
    /// </summary>
    /// <param name="ar"></param>
    private void ReceiveCallBack(IAsyncResult ar)
    {
        try
        {
            //接收后结束收取
            int len = m_Client.EndReceive(ar);
            if (len > 0)
            {
                //把接收到的数据写入缓冲数据流的尾部
                m_ReceiveStream.Position = m_ReceiveStream.Length;

                //把指定长度的字节 写入数据流
                m_ReceiveStream.Write(m_ReceiveBuffer, 0, len);

                //如果缓存数据流的长度>2 说明至少有个不完整的包过来了
                //为什么这里是2 因为我们客户端封装数据包 用的ushort 长度就是2
                if (m_ReceiveStream.Length > 2)
                {
                    //进行循环 拆分数据包
                    while (true)
                    {
                        //把数据流指针放在0处
                        m_ReceiveStream.Position = 0;

                        //读取包体长度
                        int currMsgLen = m_ReceiveStream.ReadUShort();

                        //总包的长度=包头长度+包体长度
                        int currFullMsgLen = 2 + currMsgLen;

                        ///如果数据流的长度>=整包的长度 说明至少收到了一个完整包
                        if (m_ReceiveStream.Length >= currFullMsgLen)
                        {
                            //定义包体的byte[] 数组
                            byte[] buffer = new byte[currMsgLen];

                            //把数据流指针放到2的位置 也就是包体的位置
                            m_ReceiveStream.Position = 2;

                            //将流中的包体读入byte[]
                            m_ReceiveStream.Read(buffer, 0, currMsgLen);

                            //异或之后的数组 减3是因为有一个bool值和校验码占3位，包内容实际大小该减3
                            byte[] bufferNew = new byte[buffer.Length - 3];

                            //是否压缩
                            bool isCompress = false;

                            //数据完整性验证码
                            ushort crc = 0;

                            //读取数据包中相关信息
                            using (StreamTool streamTool = new StreamTool(buffer))
                            {
                                isCompress = streamTool.ReadBool();
                                crc = streamTool.ReadUShort();
                                streamTool.Read(bufferNew, 0, bufferNew.Length);
                            }

                            //计算crc值 比较是否与收到的值相同 以校验完整性
                            int newCrc = Crc16.CalculateCrc16(bufferNew);
                            if (newCrc == crc)
                            {
                                //进行解密得到原始数据
                                bufferNew = SecurityUtil.Xor(bufferNew);

                                //如果进行过压缩，进行解压缩
                                if (isCompress)
                                {
                                    bufferNew = ZlibHelper.DeCompressBytes(bufferNew);
                                }
                                //读取包内容
                                //读取包中协议编号
                                ushort protoCode = 0;
                                byte[] protoContent = new byte[bufferNew.Length - 2];

                                using (StreamTool streamTool = new StreamTool(bufferNew))
                                {
                                    //读取协议编号
                                    protoCode = streamTool.ReadUShort();

                                    //读取协议内容
                                    streamTool.Read(protoContent, 0, protoContent.Length);
                                }

                                m_ProtoCode = protoCode;
                                m_ProtoContent = protoContent;
                         
                                //处理剩余字节数组

                                //以获取的流长度减去总包长度获得剩余字节长度
                                int remainLen = (int)m_ReceiveStream.Length - currFullMsgLen;
                                if (remainLen > 0)
                                {
                                    //把位置设为第一个包的尾部
                                    m_ReceiveStream.Position = currFullMsgLen;

                                    //定义剩余字节数组
                                    byte[] remainBuffer = new byte[remainLen];

                                    //把数据流读到剩余字节数组
                                    m_ReceiveStream.Read(remainBuffer, 0, remainLen);

                                    //清空数据流
                                    m_ReceiveStream.Position = 0;
                                    m_ReceiveStream.SetLength(0);

                                    //把剩余字节数组重新写入数据流
                                    m_ReceiveStream.Write(remainBuffer, 0, remainBuffer.Length);
                                    remainBuffer = null;
                                }
                                else
                                {
                                    //没有剩余字节
                                    //清空数据流
                                    m_ReceiveStream.Position = 0;
                                    m_ReceiveStream.SetLength(0);
                                    break;
                                }
                            }
                            else
                            {
                                //还没有收到完整包
                                break;
                            }

                        }

                    }

                    //接收完毕后 继续下一次接收
                    Debug.Log("收到完整数据包");
                    ReceiveMsg();
                }
                else
                {
                    //服务器断开连接
                    Debug.Log("服务器"+m_Client.RemoteEndPoint.ToString()+ "断开连接");
                    this.Connecting = false;
                    ErrorType = DownErrorType.ServiceDown;
                }
            }
        }
        catch (Exception ex)
        {
            //服务器断开连接
            Debug.Log("服务器" + m_Client.RemoteEndPoint.ToString() + "断开连接  原因" + ex.Message);
            this.Connecting = false;
            ErrorType = DownErrorType.ServiceDown;
        }
    }


    #endregion

}
