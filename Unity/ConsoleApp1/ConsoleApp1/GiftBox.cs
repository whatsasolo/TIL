using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace GiftBoxNamespace
{
    class GiftBox
    {
        public char CharLetter = '\0';
        public string? Letter = null; // nullable 가능함
        public int Money = 0;
        public ITEM_GRADE Grade; // 유니크아이템, 레어아이템, 노멀아이템
    }
}
