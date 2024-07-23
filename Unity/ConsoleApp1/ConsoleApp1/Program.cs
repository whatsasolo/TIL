using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    // Methode (함수)
    // 1. 정리하기 위해, 2. 반복을 단순화
    class GiftBox
    {
        public char CharLetter = '\0';
        public string? Letter = null; // nullable 가능함

        public int Money; // 4byte
        public long LongMoney = 10000000000; // 8byte

        public float FloatMoney = 10000.0f; // 4byte
        public double DoubleMoney = 100000000.0; // 8byte // 끝에 d 또는 생략해야함
        // 실수형 float와 double 중 float는 문제를 일으키는 경우가 많음
        // double 권장
        // 보통 서버에 보낼때 숫자에 값을 곱해서 소수점을 지움.
        // 물론 서버와 클라이언트가 미리 맞춰야함

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

            // foreach

            foreach (GiftBox item in giftBoxList)
            {
                item.Money = 0;
            }

            // var을 쓰면 추론형식임
            // var money = 1; <- int로 인식함
            //foreach (var item in giftBoxList)
            //{
            //    item.Money = 0;
            //}

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
