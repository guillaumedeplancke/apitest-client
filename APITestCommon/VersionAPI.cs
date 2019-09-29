using System;
using System.Collections.Generic;
using System.Text;

namespace APITestCommon
{
    class VersionAPI
    {
        public static int getRandomInteger()
        {
            Random random = new Random();
            return random.Next(1, 1000);
        }
    }
}
