public static string StringEnCode(string str)
{
    if (str.Length == 0)
    {
        return string.Empty;
    }
    byte[] bytes = Encoding.UTF8.GetBytes(str);
    int length = StringEncryptKey.Length;
    StringBuilder builder = new StringBuilder();
    Random random = new Random();
    for (int i = 0; i < bytes.Length; i++)
    {
        int num = (byte) random.Next(6);
        bytes[i] = (byte) (bytes[i] ^ num);
        int startIndex = bytes[i] % length;
        int num3 = bytes[i] / length;
        num3 = (num3 * 8) + num;
        builder.Append(StringEncryptKey.Substring(startIndex, 1) + StringEncryptKey.Substring(num3, 1));
    }
    return builder.ToString();
}

 
