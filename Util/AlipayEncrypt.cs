﻿using System;
using System.Text;
using System.Security.Cryptography;

namespace SS.AlipaySDK.Util
{
    public class AlipayEncrypt
    {

        /// <summary>
        /// 128位0向量
        /// </summary>
        private static byte[] AES_IV = initIv(16);

        /// <summary>
        /// AES 加密
        /// </summary>
        /// <param name="encryptKey"></param>
        /// <param name="bizContent"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static string AesEncrypt(string encryptKey, string bizContent, string charset)
        {

            Byte[] keyArray = Convert.FromBase64String(encryptKey);
            byte[] toEncryptArray;
            if (string.IsNullOrEmpty(charset))
            {
                toEncryptArray = Encoding.UTF8.GetBytes(bizContent);
            }
            else
            {
                toEncryptArray = Encoding.GetEncoding(charset).GetBytes(bizContent);
            }

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;
            rDel.IV = AES_IV;

            ICryptoTransform cTransform = rDel.CreateEncryptor(rDel.Key, rDel.IV);
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);


            return Convert.ToBase64String(resultArray);

        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="encryptKey"></param>
        /// <param name="bizContent"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static string AesDencrypt(string encryptKey, string bizContent, string charset)
        {
            Byte[] keyArray = Convert.FromBase64String(encryptKey);
            Byte[] toEncryptArray = Convert.FromBase64String(bizContent);

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;
            rDel.IV = AES_IV;

            ICryptoTransform cTransform = rDel.CreateDecryptor(rDel.Key, rDel.IV);
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);


            if (string.IsNullOrEmpty(charset))
            {
                return Encoding.UTF8.GetString(resultArray);
            }
            else
            {
                return Encoding.GetEncoding(charset).GetString(resultArray);
            }


        }

        /// <summary>
        /// 初始化向量
        /// </summary>
        /// <param name="blockSize"></param>
        /// <returns></returns>
        private static byte[] initIv(int blockSize)
        {
            byte[] iv = new byte[blockSize];
            for (int i = 0; i < blockSize; i++)
            {
                iv[i] = (byte)0x0;
            }
            return iv;

        }
    }
}
