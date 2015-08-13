public static string StringDeCode(string str)
{
    if (string.IsNullOrEmpty(str))
    {
        return string.Empty;
    }
    try
    {
        int index = 0;
        int length = StringEncryptKey.Length;
        byte[] bytes = new byte[str.Length / 2];
        for (int i = 0; i < str.Length; i += 2)
        {
            int num2 = StringEncryptKey.IndexOf(str[i]);
            int num3 = StringEncryptKey.IndexOf(str[i + 1]);
            int num = num3 / 8;
            num3 -= num * 8;
            bytes[index] = (byte) ((num * length) + num2);
            bytes[index] = (byte) (bytes[index] ^ num3);
            index++;
        }
        return Encoding.UTF8.GetString(bytes);
    }
    catch
    {
        return string.Empty;
    }
}

 
