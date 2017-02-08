using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello this is Grade Book Program ...");
            */

            GradeBook book = new GradeBook();

            book.addGrade(91);
            book.addGrade(89.5f);

            Statistics stat=book.ComputeStatistics();
            Console.WriteLine("Avrage Grade  = " + stat.AvrageGrade);
            Console.WriteLine("Lowest Grade  = " + stat.LowestGrade);
            Console.WriteLine("Highest Grade = " + stat.HighestGrade);
        }
    }
}
