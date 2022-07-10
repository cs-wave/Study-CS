using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lotto lotto = new Lotto(1, 46);

            lotto.Make();
            Console.WriteLine(lotto.Get());

            Console.ReadLine();

            int a = lotto.GetMinimum();
            lotto.SetMinimum(a);

            int b = lotto.Minimum;
            lotto.Minimum = b;
        }
    }

    public class Lotto
    {
        private int[] nums;
        private int minimum;
        private int maximum;

        public Lotto(int min, int max)
        {
            this.minimum = min;
            this.maximum = max;
        }

        public void Make()
        {
            this.nums = new int[6];

            for (int i = 0; i< 6; i++)
            {
                this.nums[i] = new Random(new Random().Next(100) + i).Next(this.minimum, this.maximum + 1);
            }
        }

        public string Get()
        {
            string result = "";
            for (int i = 0; i < 6;i ++)
            {
                result += this.nums[i] + " ";
            }
            return result;
        }

        public int GetMinimum()
        {
            return this.minimum;
        }

        public void SetMinimum(int data)
        {
            this.minimum = data;
        }

        public int Minimum { get { return this.minimum; } set { this.minimum = value; } }
    }
}
