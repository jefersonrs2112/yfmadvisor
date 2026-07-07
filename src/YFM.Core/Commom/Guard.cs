using System;

namespace YFM.Core.Common
{
    public static class Guard
    {
        public static void AgainstNull(object obj, string name)
        {
            if (obj == null)
                throw new ArgumentNullException(name);
        }

        public static void AgainstEmpty(string value, string name)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(name);
        }
    }
}
