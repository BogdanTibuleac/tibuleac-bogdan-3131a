﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tibuleac_bogdan_3131a_l4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Window3D ex = new Window3D())
            {
                ex.Run(30.0, 0.0);
            }
        }
    }
}
