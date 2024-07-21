using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class GiftBox
    {
        public string Letter;
        public int Money;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 인스턴스 생성
            GiftBox addressA = new GiftBox()
            {
                Letter = "하이",
                Money = 100000,
            };

            GiftBox addressB = new GiftBox()
            {
                Letter = "하이",
                Money = 100000,
            };

            GiftBox addressC = new GiftBox()
            {
                Letter = "하이",
                Money = 100000,
            };
            Console.WriteLine(a.Letter);
            Console.WriteLine(a.Money);
            // 인스턴스 주소 전달
            GiftBox b = a;
            
            // 인스턴스 내용 변경
            a.Letter = "잘 니내냐";
            a.Money = 150000;

            Console.WriteLine(a.Letter);
            Console.WriteLine(a.Money);
        }
    }
}
