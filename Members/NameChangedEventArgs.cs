﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
   public class NameChangedEventArgs : EventArgs

    {
        public string EgsistingName { get; set; }
        public string NewName { get; set; }
    }
}
