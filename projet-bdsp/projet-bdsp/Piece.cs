﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projet_bdsp
{
    class Piece
    {
        public Cell[] Cells { get; set; }

        public struct Cell
        {
            public byte X { get; set; }
            public byte Y { get; set; }

            public Cell(byte x, byte y)
            {
                X = x;
                Y = y;
            }
        }
    }
}