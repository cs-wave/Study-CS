using System;
using System.Collections.Generic;

namespace LSW
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Lotto lotto = new Lotto(1, 6);

                Console.WriteLine(lotto.GetLotto());
                Console.ReadLine();
            }
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

        private bool Overlap()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    if (this.nums[i] == this.nums[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public string GetLotto()
        {
            this.nums = new int[6];

            string result;

            do 
            {
                result = "";

                for (int i = 0; i < 6; i++)
                {
                    this.nums[i] = new Random(i + DateTime.Now.Millisecond).Next(this.minimum, this.maximum + 1);

                    result += $"{this.nums[i]} ";
                    //result += this.nums[i] + " ";
                }

            } while (Overlap());

            return result;
        }
    }
}