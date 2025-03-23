using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snappymob
{
    class ChallengeA
    {
        public static int randomIntegers()
        {
            Random rnd = new Random();
            int num = rnd.Next();

            return num;
        }

        public static double randomRealNumbers()
        {
            Random rnd = new Random();
            double num = rnd.NextDouble();

            return num;
        }

        public static string randomAlphabetical()
        {
            Random rnd = new Random();
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            char[] newAlpha = new char[10];

            for (int i = 0; i < 10; i++)
            {
                newAlpha[i] = alpha[rnd.Next(alpha.Length)];
            }

            return new string(newAlpha);
        }

        public static string randomAlphanumerics()
        {
            Random rnd = new Random();
            string alpha = "abcdefghijklmnopqrstuvwxyz1234567890";
            char[] newAlpha = new char[10];

            for (int i = 0; i < 10; i++)
            {
                newAlpha[i] = alpha[rnd.Next(alpha.Length)];
            }

            return new string(" " + newAlpha + " ");
        }

        public static void generateRandomFile()
        {
            string alphabetical = randomAlphabetical();
            string realNumbers = randomRealNumbers().ToString();
            string integers = randomIntegers().ToString();
            string alphanumerics = randomAlphanumerics();

            //StringBuilder newRandomString = new StringBuilder();
            //newRandomString.Append(alphabetical + "," + realNumbers + "," + integers + "," + alphanumerics);
            string newRandomString = alphabetical + "," + realNumbers + "," + integers + "," + alphanumerics;
            File.AppendAllText("RandomFile.txt", newRandomString);

        }
    }
}
