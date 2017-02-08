using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class GradeBook
    {
        private List<float> grades;

        public GradeBook()
        {
            grades = new List<float>();

        }

        public void addGrade(float grade)
        {
            grades.Add(grade);
        }

        public Statistics ComputeStatistics() 
        {
            Statistics stats = new Statistics();
            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(stats.HighestGrade, grade);
                stats.LowestGrade = Math.Min(stats.LowestGrade, grade);
                sum += grade;
            }
            stats.AvrageGrade = sum / grades.Count;
             
                

            return stats;
        }
    }
}
