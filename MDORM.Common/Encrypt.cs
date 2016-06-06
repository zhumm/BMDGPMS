using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MDORM.Common
{
    /// <summary>
    /// MD5加密类
    /// </summary>
    public class Encrypt
    {
        /// <summary>
        /// 采用MD5加密一段文字
        /// </summary>
        /// <param name="source">加密源</param>
        /// <returns>加密后的字符</returns>
        public static string MD5Encrypt(string source)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(source));

            StringBuilder sb = new StringBuilder(16);
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("2X"));
            }
            return sb.ToString().ToUpper();
        }
    }
}
