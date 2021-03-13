using System;

namespace Rest.Core
{
    public static class FileExtensionManager
    {
        public static string ToBase64(this byte[] array)
        {
            if (array == null || array.Length == 0)
            {
                return string.Empty;
            }

            try
            {
                return Convert.ToBase64String(array);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static byte[] FromBase64(this string base64)
        {
            if (string.IsNullOrEmpty(base64))
            {
                return null;
            }
            try
            {
                return Convert.FromBase64String(base64);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
