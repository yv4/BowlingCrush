using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

//流读写工具(byte,short,int ,long ,float,decimal,bool,string)
public class StreamTool : MemoryStream {

    public StreamTool()
    {

    }

    public StreamTool(byte[] buffer) : base(buffer)
    {

    }

    #region 读写Short
    /// <summary>
    /// 从流中读取一个Short数据
    /// </summary>
    /// <returns></returns>
    public short ReadShort()
    {
        byte[] arr = new byte[2];
        base.Read(arr, 0, 2);
        return BitConverter.ToInt16(arr, 0);
    }

    /// <summary>
    /// 把一个short数据写入流
    /// </summary>
    /// <param name="value"></param>
    public void WriteShort(short value)
    {
        byte[] arr = BitConverter.GetBytes(value);
        base.Write(arr, 0, arr.Length);
    }
    #endregion

    #region 读写UShort

    /// <summary>
    /// 从流中读取一个UShort
    /// </summary>
    /// <returns></returns>
    public ushort ReadUShort()
    {
        byte[] arr = new byte[2];
        base.Read(arr, 0, 2);
        return BitConverter.ToUInt16(arr, 0);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    public void WriteUShort(ushort value)
    {
        byte[] arr = BitConverter.GetBytes(value);
        base.Write(arr, 0, arr.Length);
    }
    #endregion

    #region 读写Int

    /// <summary>
    /// 读取一个int数据
    /// </summary>
    /// <returns></returns>
    public int ReadInt()
    {
        byte[] arr = new byte[4];
        base.Read(arr, 0, 4);
        return BitConverter.ToInt32(arr, 0);
    }

    /// <summary>
    /// 写入一个int数据
    /// </summary>
    /// <param name="value"></param>
    public void WriteInt(int value)
    {
        byte[] arr = BitConverter.GetBytes(value);
        base.Write(arr, 0, arr.Length);
    }
    #endregion

    #region 读写UInt

    /// <summary>
    /// 读取一个uint数据
    /// </summary>
    /// <returns></returns>
    public uint ReadUInt()
    {
        byte[] arr = new byte[4];
        base.Read(arr, 0, 4);
        return BitConverter.ToUInt32(arr, 0);
    }

    /// <summary>
    /// 写入一个uint
    /// </summary>
    /// <param name="value"></param>
    public void WriteUInt(uint value)
    {
        byte[] arr = BitConverter.GetBytes(value);
        base.Write(arr, 0, arr.Length);
    }
    #endregion

    #region 读写Long

    /// <summary>
    /// 读取一个Long数据
    /// </summary>
    /// <returns></returns>
    public long ReadLong()
    {
        byte[] arr = new byte[8];
        base.Read(arr, 0, 8);
        return BitConverter.ToInt64(arr, 0);
    }

    /// <summary>
    /// 把一个long数据写入流
    /// </summary>
    /// <param name="value"></param>
    public void WriteLong(long value)
    {
        byte[] arr = BitConverter.GetBytes(value);
        base.Write(arr, 0, arr.Length);
    }

    #endregion

    #region 读写ULong

    /// <summary>
    /// 读取一个ULong数据
    /// </summary>
    /// <returns></returns>
    public ulong ReadULong()
    {
        byte[] arr = new byte[4];
        base.Read(arr, 0, 4);
        return BitConverter.ToUInt64(arr, 0);
    }

    /// <summary>
    /// 写入一个ULong数据
    /// </summary>
    public void WriteULong(ulong value)
    {
        byte[] arr = BitConverter.GetBytes(value);
        base.Write(arr, 0, arr.Length);
    }
    #endregion

    #region 读写Float

    /// <summary>
    /// 读取float数据
    /// </summary>
    /// <returns></returns>
    public float ReadFloat()
    {
        byte[] arr = new byte[4];
        base.Read(arr, 0, 4);
        return BitConverter.ToSingle(arr, 0);
    }


    /// <summary>
    /// 写入float数据
    /// </summary>
    /// <param name="value"></param>
    public void WriteFloat(float value)
    {
        byte[] arr = BitConverter.GetBytes(value);
        base.Write(arr, 0, arr.Length);
    }
    #endregion

    #region 读写Double
    /// <summary>
    /// 读取一个Double数据
    /// </summary>
    /// <returns></returns>
    public double ReadDouble()
    {
        byte[] arr = new byte[8];
        base.Read(arr, 0, 8);
        return BitConverter.ToDouble(arr, 0);
    }

    /// <summary>
    /// 写入一个Double数据
    /// </summary>
    /// <param name="value"></param>
    public void WriteDouble(double value)
    {
        byte[] arr = BitConverter.GetBytes(value);
        base.Write(arr, 0, arr.Length);
    }
    #endregion

    #region 读写Bool

    /// <summary>
    /// 读取一个Bool数据
    /// </summary>
    /// <returns></returns>
    public bool ReadBool()
    {
        return base.ReadByte() == 1;
    }

    /// <summary>
    /// 写入一个数据流
    /// </summary>
    public void WriteBool(bool value)
    {
        base.WriteByte((byte)(value == true ? 1 : 0));
    }

    #endregion

    #region 读写String

    /// <summary>
    /// 读取String数组
    /// </summary>
    /// <returns></returns>
    public string ReadUTF8String()
    {
        //读取字符串长度
         ushort len = this.ReadUShort();
        byte[] arr = new byte[len];
        //读取字符串内容
        base.Read(arr, 0, len);
        return Encoding.UTF8.GetString(arr);
    }
    

    public void WriteUTF8String(string str)
    {
        byte[] arr = Encoding.UTF8.GetBytes(str);
        if (arr.Length > 65545)
        {
            throw new InvalidCastException("字符串超出范围");
        }

        //写入字符串长度
        this.WriteUShort((ushort)arr.Length);
        //写入字符串内容
        base.Write(arr, 0, arr.Length);
    }

    #endregion
}
