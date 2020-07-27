using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

namespace MobiiGame.Common
{
    public static class CommonUtil
    {
        public static string Md5Sum(string value)
        {
            //将字符串以UTF-8格式转为byte数组
            byte[] resultBytes = Encoding.UTF8.GetBytes(value);

            //创建一个MD5的对象
            MD5 md5 = new MD5CryptoServiceProvider();

            //调用MD5的ComputeHash方法将字节数组加密
            byte[] outPut = md5.ComputeHash(resultBytes);

            StringBuilder hashString = new StringBuilder();

            //最后把加密后的字节数组转为字符串
            for (int i = 0; i < outPut.Length; i++)
            {
                hashString.Append(Convert.ToString(outPut[i], 16).PadLeft(2, '0'));
            }

            return hashString.ToString();
        }


        /// <summary>
        /// 默认密钥向量
        /// </summary>
        private static byte[] _IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF, 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

        private static int _blocksize = 16;

        /// <summary>
        /// AES加密算法
        /// </summary>
        /// <param name="plainText">明文字符串</param>
        /// <param name="strKey">密钥</param>
        /// <returns>返回加密后的密文字节数组</returns>
        public static byte[] AESEncrypt(string plainText, string strKey)
        {
            //分组加密算法
            SymmetricAlgorithm des = Rijndael.Create();
            
            byte[] inputByteArray = Encoding.UTF8.GetBytes(plainText);//得到需要加密的字节数组
            //int covering = (inputByteArray.Length + 1) % 16;
            //int coveringLength = 0;
            //if (covering != 0)//手动补位
            //{
            //    coveringLength = 16 - covering;
            //}

            int dataLength = inputByteArray.Length;// + 1);// + coveringLength;
            byte[] dataArray = new byte[dataLength];
            Buffer.BlockCopy(inputByteArray, 0, dataArray, 0, inputByteArray.Length);
            //dataArray[dataArray.Length - 1] = Convert.ToByte(coveringLength);

            //设置密钥及密钥向量
            des.Key = Encoding.UTF8.GetBytes(strKey);
            des.IV = _IV;
            des.Mode = CipherMode.CFB;
            des.Padding = PaddingMode.Zeros;

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(dataArray, 0, dataArray.Length);
            cs.FlushFinalBlock();
            byte[] cipherBytes = ms.ToArray();//得到加密后的字节数组
            cs.Close();
            ms.Close();

            // 将iv值拷贝到最前面
            byte[] result = new byte[cipherBytes.Length + _IV.Length];
            Buffer.BlockCopy(_IV, 0, result, 0, _IV.Length);
            Buffer.BlockCopy(cipherBytes, 0, result, _IV.Length, cipherBytes.Length);
            
            return result;
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="cipherText">密文字节数组</param>
        /// <param name="strKey">密钥</param>
        /// <returns>返回解密后的字符串</returns>
        public static byte[] AESDecrypt(byte[] cipherText, string strKey)
        {
            // iv 在原始数组的前16字节
            byte[] iv = new byte[_blocksize];
            Buffer.BlockCopy(cipherText, 0, iv, 0, _blocksize);

            SymmetricAlgorithm des = Rijndael.Create();
            des.Key = Encoding.UTF8.GetBytes(strKey);
            des.IV = iv;
            des.Mode = CipherMode.CFB;
            //des.BlockSize = _blocksize;
            des.Padding = PaddingMode.Zeros;
            
            int decryptLen = cipherText.Length - _blocksize;

            byte[] decryptBytes = new byte[decryptLen];

            MemoryStream ms = new MemoryStream(cipherText, _blocksize, decryptLen);
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Read);
            cs.Read(decryptBytes, 0, decryptBytes.Length);
            cs.FlushFinalBlock();
            cs.Close();
            ms.Close();

            

            //int len = Convert.ToInt32(decryptBytes[decryptBytes.Length - 1]);

            //// 总的长度减去补齐的长度，则是加密串的长度
            //int length = Convert.ToInt32(decryptBytes.Length - 1);
            //byte[] databytes = new byte[decryptBytes.Length - 1 - length];
            //Buffer.BlockCopy(decryptBytes, 0, databytes, 0, databytes.Length);

            return decryptBytes;
        }


        public static string Byte2String(byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }

        //static readonly char[] padding = { '=' };

        //public static string ToBase64String(string value)
        //{
        //    byte[] toEncodeAsBytes = Encoding.UTF8.GetBytes(value);
        //    return Convert.ToBase64String(toEncodeAsBytes).TrimEnd(padding).Replace('+', '-').Replace('/', '_');
        //}

        //public static string ToBase64String(byte[] value)
        //{
        //    //byte[] toEncodeAsBytes = Encoding.UTF8.GetBytes(value);
        //    return Convert.ToBase64String(value).TrimEnd(padding).Replace('+', '-').Replace('/', '_');
        //}

        //public static byte[] FromBase64String(string value)
        //{
        //    string incoming = value.Replace('_', '/').Replace('-', '+');

        //    //switch (incoming.Length % 4)
        //    //{
        //    //    case 2: incoming += "=="; break;
        //    //    case 3: incoming += "="; break;
        //    //}

        //    return Convert.FromBase64String(incoming);
        //}
    }
}
