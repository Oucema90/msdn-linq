﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msdn_linq_samples.Anonymous_Types
{
    public class FirstLetterWords
    {
        public char FirstLetter { get; set; }

        public IGrouping<char, string> Words { get; set; }
    }
}
