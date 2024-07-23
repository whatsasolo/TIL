using GiftBoxNamespace;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace GiftBoxManageNamespace
{
    class GiftBoxManager
    {
        public void SetInit()
        {
            GiftBox addressA = GiftBoxMaker("A 하이", 100000, ITEM_GRADE.UNIQUE);
            GiftBox addressB = GiftBoxMaker("B 하이", 110000, ITEM_GRADE.RARE);
            GiftBox addressC = GiftBoxMaker("C 하이", 120000, ITEM_GRADE.NORMAL);
        }

        private static GiftBox GiftBoxMaker(string letter, int money, ITEM_GRADE iTEM_GRADE)
        {
            // 인스턴스 생성
            GiftBox address = new GiftBox()
            {
                Letter = letter,
                Money = money,
                Grade = iTEM_GRADE,
            };
            return address;
        }
    }
}
