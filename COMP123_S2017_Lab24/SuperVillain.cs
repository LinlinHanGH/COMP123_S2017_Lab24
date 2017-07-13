﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Linlin Han
 * Date: July 13, 2017
 * Description: This is the SuperVillain class which inherits from the SuperHuman class
 * Version: 0.1 - Added the SuperVillain class
 */

namespace COMP123_S2017_Lab24_SuperVillain
{
    /// <summary>
    /// This is the SuperVillain class
    /// </summary>
    public class SuperVillain:SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _malice;

        // PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;
            }

            set
            {
                this._malice = value;
            }
        }
    }
}
