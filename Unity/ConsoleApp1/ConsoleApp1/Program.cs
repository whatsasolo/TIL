using GiftBoxManageNamespace;
using GiftBoxNamespace;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    // Methode (함수)
    // 1. 정리하기 위해, 2. 반복을 단순화

    internal class Program
    {
        static void Main(string[] args)
        {

            int money = 10000;
            float floatMoney = 10.0f;
            double doubleMoney = 20.0;
            string letter = "스트링";

            // int money -> string letter
            // letter = money.ToString();
            // letter = money + ""; // 자동 형변환

            // float floatMoney -> double doubleMoney
            doubleMoney = floatMoney; // double의 범위가 더 크기때문에 자동 형변환 됨

            // double doubleMoney -> float floatMoney
            floatMoney = (float)doubleMoney; // 데이터가 절삭됨 // 문제 발생 소지 큼

            // string letter -> int money
            // money = int.Parse(letter); // 안전하지 않음

            int.TryParse(letter, out money); // 형변환 실패하면 money 값이 들어감
            Console.WriteLine(money);


            double value = 30.0 + 10.1f;
            // float value2 = 30.0 + 10.1f; // 에러, 더블 + 플롯 = 더블 <- 자료형이 큰 것으로 연산 결과가 됨
        }
    }
}
