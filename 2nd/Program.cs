using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PropertiesTest test = new PropertiesTest(1);

            int i = test.GetCount();
            test.SetCount(2);

            i = test.Count;
            test.Count = -1;

            string str = "hello";
        }
    }

    public class PropertiesTest
    {
        private int count;

        public PropertiesTest(int count)
        {
            this.count = count;
        }

        public int GetCount()
        {
            return this.count;
        }

        public void SetCount(int count)
        {
            this.count = count;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                if (this.count < 0)
                {
                    this.count = 0;
                }
                this.count = value;
            }
        }
    }
}
