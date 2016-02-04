using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class tabFreq
    {
        private int value;
        private char key;
        public SortedDictionary<char, double> dic = new SortedDictionary<char, double>();
   
        public tabFreq()
        {
            this.dic['a'] = 8.91;
            this.dic['i'] = 8.21;
            this.dic['o'] = 7.75;
            this.dic['e'] = 7.66;
            this.dic['z'] = 5.64;
            this.dic['n'] = 5.52;
            this.dic['r'] = 4.69;
            this.dic['w'] = 4.65;
            this.dic['s'] = 4.32;
            this.dic['t'] = 3.98;
            this.dic['c'] = 3.96;
            this.dic['y'] = 3.76;
            this.dic['k'] = 3.51;
            this.dic['d'] = 3.25;
            this.dic['p'] = 3.13;
            this.dic['m'] = 2.80;
            this.dic['u'] = 2.50;
            this.dic['j'] = 2.28;
            this.dic['l'] = 2.10;
            this.dic['ł'] = 1.82;
            this.dic['b'] = 1.47;
            this.dic['g'] = 1.42;
            this.dic['ę'] = 1.11;
            this.dic['h'] = 1.08;
            this.dic['ą'] = 0.99;
            this.dic['ó'] = 0.85;
            this.dic['ż'] = 0.83;
            this.dic['ś'] = 0.66;
            this.dic['ć'] = 0.40;
            this.dic['f'] = 0.30;
            this.dic['ń'] = 0.20;
            this.dic['q'] = 0.14;
            this.dic['ź'] = 0.06;
            this.dic['v'] = 0.04;
            this.dic['x'] = 0.02;
        }
    }
}
