﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Linlin Han
 * Date: July 13, 2017
 * Description: This Interface lists the signature for any Super Hero Subclass
 * Version: 0.1 - declared the Karma property
 */

namespace COMP123_S2017_Lab24_SuperVillain
{

    public interface IHasKarma
    {
        // PUBLIC PROPERTIES
        int Karma { get; set; }
    }
}