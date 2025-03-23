using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snappymob
{
    class ChallengeB
    {
        public static void readRandomFile()
        {
            string randomFile = @"RandomFile.txt";

            if (File.Exists(randomFile))
            {
                string[] lineRnd = File.ReadAllLines(randomFile);
                foreach (string line in lineRnd)
                {
                    string[] rnd = line.Split(',');

                    Console.WriteLine(rnd[0] + " Type:Alphabetical Strings,");
                    Console.WriteLine(rnd[1] + " Type:Real Numbers");
                    Console.WriteLine(rnd[2] + " Type:Integers");
                    Console.WriteLine(rnd[3].Split(' ') + " Type:Alphanumerics");

                }                    
            }
        }
    }
}
