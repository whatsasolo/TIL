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

            GiftBoxManager giftBoxManager = new GiftBoxManager();
            giftBoxManager.SetInit();
        }
    }
}
