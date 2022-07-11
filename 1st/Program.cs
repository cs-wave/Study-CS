using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st
{
    public class Heart
    {
        private bool power;
        private string record;

        public Heart()
        {
            this.power = false;
            this.record = "";
        }

        public void OnOff()
        {
            this.power = !this.power;
        }

        public void Push(string str)
        {
            if (this.power)
            {
                this.record = str;
            }
        }

        public void Click()
        {
            if (this.power)
                Console.WriteLine(this.record);
        }
    }

    public class Radio
    {
        private int frequance;
        private int volume;
        private bool power;

        public Radio()
        {
            this.frequance = 0;
            this.volume = 50;
            this.power = false;
        }

        public void OnOff()
        {
            this.power = !this.power;
        }

        public void Volume(int num)
        {
            if (this.power)
            {
                this.volume += num;
            }
        }

        public void Freaunace(int num)
        {
            if (this.power)
            {
                this.frequance += num;
            }
        }

        public void Show()
        {
            if (this.power)
            {
                Console.WriteLine($"라디오가 {this.frequance}에서 {this.volume}의 소리로 작동중입니다.");
            }
            else
            {
                Console.WriteLine("라디오가 꺼져있습니다.");
            }
        }
    }

    public class Fan
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.OnOff();
            radio.Volume(50);
            radio.Freaunace(255);
            radio.Show();

            Radio radio1 = new Radio();
            radio1.Volume(30);
            radio1.Freaunace(255);
            radio1.Show();

            Heart heart = new Heart();
            heart.OnOff();
            heart.Push("hihihi");
            heart.Click();

            Console.ReadLine();
        }
    }
}

/// foreach 설명용
//char[] chars = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//for (int i = 0; i < chars.Length; i++)
//{
//    Console.WriteLine(chars[i]);
//}

//foreach (char c in chars)
//{
//    Console.WriteLine(c);
//}


/// 레퍼런스 변수와 밸류 변수 차이
//class Obj
//{
//    public int i;
//}

//static void Main(string[] args)
//{
//    Obj obj = new Obj();
//    obj.i = 1;
//    Objs(obj);
//    Console.WriteLine(obj.i);

//    //int i = 10;
//    //Ints(ref i);
//    //Console.WriteLine(i);

//    Console.ReadLine();
//}

//static void Ints(ref int i)
//{
//    i += 10;
//}

//static void Objs(Obj obj)
//{
//    obj.i += 1;
//}