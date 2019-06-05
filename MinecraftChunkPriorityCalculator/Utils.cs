using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftChunkPriorityCalculator
{
    static class Utils
    {
        /// <summary>
        /// Uses the algorithm shown in gnembon's video about Permanent and Remote Chunk Loading with Perma-Loader in Minecraft to calculate chunk priority.
        /// </summary>
        public static string calculatePriority(int xin, int yin)
        {

            //Input from textbox's string to integer and then to signed binary in a string.
            String x = Convert.ToString(xin, 2);
            String y = Convert.ToString(yin, 2);

            //Xoring the two integers together to obtain a 32 bit signed in xor1 as string.
            string xor1 = xorStrings(x, y).PadLeft(32, '0');

            //Splits the first and second half of xor1(32bit) to obtain two 16 bit halfs.
            string[] table = splitInHalf(xor1);
            string a = table[0];
            string b = table[1];

            //Xoring those two half to obtain a single 16bit value that represents the priority of the chunk.
            string xor2 = xorStrings(a, b);

            //Converts from bits in string(xor2)  to int(priority).
            int priority = Convert.ToInt32(xor2, 2);
            //Sets label value.
            return priority.ToString();


        }

        public static string xorStrings(string a, string b)
        {
            string output = "";
            //Obtains the biggest lenght between the two.
            int len = Math.Max(a.Length, b.Length);

            //Adds padding so both have same lenght (fills with zeros)
            a = a.PadLeft(len, '0');
            b = b.PadLeft(len, '0');


            for (int i = 0; i < len; i++)
            {
                //Compares bit by bit to xor the two values.
                output += a[i] == b[i] ? '0' : '1';
            }
            return output;
        }
        public static string[] splitInHalf(string input)
        {
            //Instanced output array.
            string[] output = new string[2];

            //Only goes half way since we only need to go through half of the bites at once.
            for (int i = 0; i < input.Length / 2; i++)
            {
                //Adds the bites of the first half.
                output[0] += input[i];
                //Adds the bites of the second half.
                output[1] += input[input.Length / 2 + i];
            }
            return output;
        }
    }
}
