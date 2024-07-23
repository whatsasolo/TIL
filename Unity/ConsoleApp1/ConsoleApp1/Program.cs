using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    // Methode (함수)
    // 1. 정리하기 위해, 2. 반복을 단순화
    class GiftBox
    {
        // nullable 가능함
        public string? Letter = null;
        public int Money;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            GiftBox addressA = GiftBoxMaker("A 하이", 100000);
            GiftBox addressB = GiftBoxMaker("B 하이", 110000);
            GiftBox addressC = GiftBoxMaker("C 하이", 120000);

            GiftBox[] giftBoxes = new GiftBox[3];
            giftBoxes[0] = addressA;
            giftBoxes[1] = addressB;
            giftBoxes[2] = addressC;

            // 배열
            GiftBox[] giftBoxes2 = {addressA, addressB, addressC };
            Console.WriteLine(giftBoxes2.Length);

            // 리스트
            List<GiftBox> giftBoxList = new List<GiftBox>();
            giftBoxList.Add(addressA);
            giftBoxList.Add(addressB);
            giftBoxList.Add(addressC);
            // 리스트 길이는 카운트 
            Console.WriteLine(giftBoxList.Count);
            // 리스트는 컬렉션 중 하나

            // giftBoxList.Clear();  // 모두 지움
            // 특정 값 지우기
            // giftBoxList.Remove(addressA);

            for (int i = 0; i < giftBoxes.Length; i++)
            {
                Console.WriteLine(giftBoxes[i].Money);
            }

            for (int i = 0; i < giftBoxList.Count; i++)
            {
                Console.WriteLine(giftBoxList[i].Money);
            }
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
