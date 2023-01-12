using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace System
{
    public static class ExtentionMethods
    {
        public static int ToInt(this string str)=> Convert.ToInt32(str);

        public static int ToInt(this object str) => Convert.ToInt32(str);

        public static int ToInt(this TextBox txt)
        {
            if (txt.Text.Trim() == "")
                return 0;
            return Convert.ToInt32(txt.Text.Trim());
        }

        public static long ToLong(this TextBox txt)
        {
            if (txt.Text.Trim() == "")
                return 0;
            return Convert.ToInt64(txt.Text.Trim());
        }

        public static string Hash(this string str)
        {
            var alg = SHA512.Create();

            byte[] buffer = System.Text.UTF8Encoding.UTF8.GetBytes(str);

            byte[] bufferedHash = alg.ComputeHash(buffer);

            return Convert.ToBase64String(bufferedHash);
        }
    }
}
