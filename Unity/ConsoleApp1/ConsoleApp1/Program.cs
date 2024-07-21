using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    // Methode (함수)
    // 1. 정리하기 위해, 2. 반복을 단순화
    class GiftBox
    {
        public string Letter;
        public int Money;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            GiftBox addressA = GiftBoxMaker("A 하이", 100000);
            GiftBox addressB = GiftBoxMaker("B 하이", 110000);
            GiftBox addressC = GiftBoxMaker("C 하이", 120000);
        }

        private static GiftBox GiftBoxMaker(string letter, int money)
        {
            // 인스턴스 생성
            GiftBox address = new GiftBox()
            {
                Letter = letter,
                Money = money,
            };
            return address;
        }
    }
}
