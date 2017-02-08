using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class Statistics
    {
        private float avrageGrade;
        private float highestGrade;
        private float lawestGrade;

        public Statistics()
        {
            lawestGrade = float.MaxValue;
            highestGrade = float.MinValue;
        }

        public float AvrageGrade
        {
            set { avrageGrade=value; }
            get { return avrageGrade; }
        }
        public float HighestGrade
        {
            set { highestGrade = value; }
            get { return highestGrade; }
        }

        public float LowestGrade
        {
            set { lawestGrade = value; }
            get { return lawestGrade; }
        }

    }
}
