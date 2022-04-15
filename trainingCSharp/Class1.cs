using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingCSharp
{
    internal class Singleton<T> where T : new()
    {
        private static Boolean isInitialized = false;
        private static T uniqueInstance;
        static readonly object lockObject = new object();

        public static T Instance()
        {
            lock (lockObject)
            {
                if (!isInitialized)
                {
                    uniqueInstance = new T();
                    isInitialized = true;
                }
                //TODO est-ce que le lock est maintenu apres le return?
                //TODO                return uniqueInstance;
            }

            return uniqueInstance;
        }
    }
}
