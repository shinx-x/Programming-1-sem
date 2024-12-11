using System;
using System.Collections.Generic;

namespace _1._1
{
    public class Test
    {
        public object Assert { get; private set; }

        public List<int> Chinazes(int n)
        {
            var result = new List<int>();
            int j = 0;
            for (int i = 2; i < n; i++)
            {
                for (j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }

                if (j > Math.Sqrt(i))
                {
                    result.Add(i);
                }
                    
            }

            return result;
        }
        
        public void Setup()
        {
        }

        public void Test1()
        {
            Assert.AreEqual(0, Chinazes(1).Count);
        }        
    }    
}