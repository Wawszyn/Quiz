﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Pytanie
    {
        public int Id { get; set; }
        public int Kategoria { get; set; }
        public string Tresc { get; set; }
        public string Odp1 { get; set; }
        public string Odp2 { get; set; }
        public string Odp3 { get; set; }
        public string Odp4 { get; set; }
    }
}
