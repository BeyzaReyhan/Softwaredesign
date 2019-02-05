using System;
using System.Collections.Generic;

namespace Endaufgabe
{
    class Block{
        public TimeSpan zeit;
        public int nummer;
        public List<Course> kurse;

        public DayEnum tag;

        public Block (TimeSpan zeit, int nummer, DayEnum tag) 
        {
            this.zeit = zeit;
            this.nummer = nummer;
            this.tag = tag;
        }
    }
}