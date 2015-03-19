namespace Engine
{
    using System;
    using System.Security.Cryptography;
    public static class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider generator = new RNGCryptoServiceProvider();

        public static int NumberGenerate(int minValue, int maxValue)
        {
            byte[] data = new byte[4];

            generator.GetBytes(data);

            int value = BitConverter.ToInt32(data, 0);
            
            return value;
        }
    }
}
