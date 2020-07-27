using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;
public interface ICryptography
{
    string Encode(string str);
    string Decode(string str);
}
public static class GPCCryptography
{
    private static ICryptography[] cryptographies = new ICryptography[] {new AES(), new DES(),
        new DES(new byte[] { 0xB1, 0xC2, 0xD3, 0xE4, 0xF5, 0x46, 0x57, 0x68 }, 
            new byte[] { 0xF8, 0xE7, 0xD6, 0xC5, 0xB4, 0xA3, 0x02, 0x91 })/* new RSA()*/
};
    public static ICryptography Take(int id)
    {
        return cryptographies[id];
    }
}
public class DES:ICryptography
{
    //密钥
    public static byte[] _KEY = new byte[] { 0xA1, 0xB2, 0xC3, 0xD4, 0xE5, 0xF6, 0x17, 0x08 };
    //向量
    public static byte[] _IV = new byte[] { 0xF8, 0xE7, 0xD6, 0xC5, 0xB4, 0xA3, 0x02, 0x91 };
    public DES() { }
    public DES(byte[] key,byte[] iv) { _KEY = key;_IV = iv; }
    /// <summary>
    /// DES加密操作
    /// </summary>
    /// <param name="normalTxt"></param>
    /// <returns></returns>
    public string Encode(string normalTxt)
    {
        //byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(_KEY);
        //byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(_IV);

        DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
        int i = cryptoProvider.KeySize;
        MemoryStream ms = new MemoryStream();
        CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateEncryptor(_KEY, _IV), CryptoStreamMode.Write);

        StreamWriter sw = new StreamWriter(cst);
        sw.Write(normalTxt);
        sw.Flush();
        cst.FlushFinalBlock();
        sw.Flush();

        string strRet = Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
        return strRet;
    }

    /// <summary>
    /// DES解密操作
    /// </summary>
    /// <param name="securityTxt">加密字符串</param>
    /// <returns></returns>
    public string Decode(string securityTxt)//解密  
    {
        //byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(_KEY);
        //byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(_IV);
        byte[] byEnc;
        try
        {
            securityTxt.Replace("_%_", "/");
            securityTxt.Replace("-%-", "#");
            byEnc = Convert.FromBase64String(securityTxt);
        }
        catch
        {
            return null;
        }
        DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
        MemoryStream ms = new MemoryStream(byEnc);
        CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateDecryptor(_KEY, _IV), CryptoStreamMode.Read);
        StreamReader sr = new StreamReader(cst);
        return sr.ReadToEnd();
    }
}
public class RSA:ICryptography
{
    private const int RsaKeySize = 2048;
    private DES eS = new DES(new byte[] { 0xB1, 0xC2, 0xD3, 0xE4, 0xF5, 0x46, 0x57, 0x68 }, new byte[] { 0xF8, 0xE7, 0xD6, 0xC5, 0xB4, 0xA3, 0x02, 0x91 });
    public string public_Key => "ADEONNNMPA";
    public string private_Key => "ADEONONMPC";
    public void Init()
    {
        string pck = $"packet{Application.identifier}";
        if (!PlayerPrefs.HasKey(pck))
        {
            PlayerPrefs.SetInt(pck, 1);
            using (var rsa = new RSACryptoServiceProvider(RsaKeySize))
            {
                try
                {
                    // 获取私钥和公钥。
                    var publicKey = rsa.ToXmlString(false);
                    var privateKey = rsa.ToXmlString(true);
                    //Debug.Log($"{publicKey},{privateKey}");
                    PlayerPrefs.SetString(public_Key,eS.Encode( publicKey));
                    PlayerPrefs.SetString(private_Key, eS.Encode( privateKey));
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }
    }

    /// <summary>
    /// 用给定路径的RSA公钥文件加密纯文本。
    /// </summary>
    /// <param name="plainText">要加密的文本</param>
    /// <param name="pathToPublicKey">用于加密的公钥路径.</param>
    /// <returns>表示加密数据的64位编码字符串.</returns>
    public string Encode(string plainText)
    {
        Init();
        using (var rsa = new RSACryptoServiceProvider(RsaKeySize))
        {
            try
            {
                //加载公钥
                var publicXmlKey = PlayerPrefs.GetString(public_Key);
                rsa.FromXmlString(eS.Decode(publicXmlKey));

                var bytesToEncrypt = Encoding.Unicode.GetBytes(plainText);

                var bytesEncrypted = rsa.Encrypt(bytesToEncrypt, false);

                return Convert.ToBase64String(bytesEncrypted);
            }
            finally
            {
                rsa.PersistKeyInCsp = false;
            }
        }
    }

    /// <summary>
    /// Decrypts encrypted text given a RSA private key file path.给定路径的RSA私钥文件解密 加密文本
    /// </summary>
    /// <param name="encryptedText">加密的密文</param>
    /// <param name="pathToPrivateKey">用于加密的私钥路径.</param>
    /// <returns>未加密数据的字符串</returns>
    public string Decode(string encryptedText)
    {
        using (var rsa = new RSACryptoServiceProvider(RsaKeySize))
        {
            try
            {
                var privateXmlKey = PlayerPrefs.GetString(private_Key);
                rsa.FromXmlString(eS.Decode(privateXmlKey));

                var bytesEncrypted = Convert.FromBase64String(encryptedText);

                var bytesPlainText = rsa.Decrypt(bytesEncrypted, false);

                return Encoding.Unicode.GetString(bytesPlainText);
            }
            finally
            {
                rsa.PersistKeyInCsp = false;
            }
        }
    }
}

public class AES:ICryptography
{
    private string key = "71911151Y1a._A1p";
    /// <summary>
    ///  AES 加密
    /// </summary>
    /// <param name="str">明文（待加密）</param>
    /// <param name="key">密文</param>
    /// <returns></returns>
    public string Encode(string str)
    {
        if (string.IsNullOrEmpty(str)) return null;
        Byte[] toEncryptArray = Encoding.UTF8.GetBytes(str);

        RijndaelManaged rm = new RijndaelManaged
        {
            Key = Encoding.UTF8.GetBytes(key),
            Mode = CipherMode.ECB,
            Padding = PaddingMode.PKCS7
        };

        ICryptoTransform cTransform = rm.CreateEncryptor();
        Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
        return Convert.ToBase64String(resultArray);
    }

    /// <summary>
    ///  AES 解密
    /// </summary>
    /// <param name="str">明文（待解密）</param>
    /// <param name="key">密文</param>
    /// <returns></returns>
    public string Decode(string str)
    {
        if (string.IsNullOrEmpty(str)) return null;
        Byte[] toEncryptArray = Convert.FromBase64String(str);

        RijndaelManaged rm = new RijndaelManaged
        {
            Key = Encoding.UTF8.GetBytes(key),
            Mode = CipherMode.ECB,
            Padding = PaddingMode.PKCS7
        };

        ICryptoTransform cTransform = rm.CreateDecryptor();
        Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

        return Encoding.UTF8.GetString(resultArray);
    }
}