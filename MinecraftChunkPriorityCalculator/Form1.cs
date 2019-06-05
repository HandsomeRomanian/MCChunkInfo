using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftChunkPriorityCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbChunkX_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void tbChunkY_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void tbPlayerX_TextChanged(object sender, EventArgs e)
        {
            tbChunkX.Text = playerToChunk(tbPlayerX.Text);
        }

        private void tbPlayerY_TextChanged(object sender, EventArgs e)
        {
            tbChunkY.Text = playerToChunk(tbPlayerY.Text);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            calculatePriority();
            getFileName();
        }
        /// <summary>
        /// Uses the algorithm shown in gnembon's video about Permanent and Remote Chunk Loading with Perma-Loader in Minecraft to calculate chunk priority.
        /// </summary>
        private void calculatePriority()
        {
            
            int intx;
            int inty;
            if (!int.TryParse(tbChunkX.Text, out intx) && tbChunkX.Text != "-")
                tbChunkX.Text = "";
            if (!int.TryParse(tbChunkY.Text, out inty) && tbChunkY.Text != "-")
                tbChunkY.Text = "";
            if (tbChunkX.Text != null && tbChunkX.Text != "" && tbChunkX.Text != "-" && tbChunkY.Text != null && tbChunkY.Text != "" && tbChunkY.Text != "-")
            {
                //Input from textbox's string to integer and then to signed binary in a string.
                String x = Convert.ToString(int.Parse(tbChunkX.Text), 2);
                String y = Convert.ToString(int.Parse(tbChunkY.Text), 2);

                //Xoring the two integers together to obtain a 32 bit signed in xor1 as string.
                string xor1 = xorStrings(x, y).PadLeft(32,'0');
                
                //Splits the first and second half of xor1(32bit) to obtain two 16 bit halfs.
                string[] table = splitInHalf(xor1);
                string a = table[0];
                string b = table[1];

                //Xoring those two half to obtain a single 16bit value that represents the priority of the chunk.
                string xor2 = xorStrings(a, b);
                
                //Converts from bits in string(xor2)  to int(priority).
                int priority = Convert.ToInt32(xor2, 2);
                //Sets label value.
                lblPriority.Text = priority.ToString();

            }
        }
        private string xorStrings(string a, string b)
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
        private string[] splitInHalf(string input)
        {
            //Instanced output array.
            string[] output = new string[2];

            //Only goes half way since we only need to go through half of the bites at once.
            for (int i = 0; i < input.Length/2; i++)
            {
                //Adds the bites of the first half.
                output[0] += input[i];
                //Adds the bites of the second half.
                output[1] += input[input.Length/2 + i];
            }
            return output;
        }
        private string playerToChunk(string coords)
        {
            //Checks if input(coords) might cause errors when converting to int.
            if (coords == null || coords == "" || coords == "-")
                return "0";
            //Instances output variable.
            string output ="";
            //Converts string input into integer.
            int value = int.Parse(coords);

            //Ajusts for negative values.(Probably not the best way)
            if (value < 0)
                output += (value / 16-1).ToString();
            else
                output += (value / 16).ToString();
            return output;
        }

        private void getFileName()
        {
            int n;
            //Sets default x and y to zero in case of error.
            int x = 0;
            int y = 0;
            //Verifies that fields have text in them.
            if (tbChunkX.Text != "-" && tbChunkX.Text != "" && int.TryParse(tbChunkX.Text, out n))
                x = int.Parse(tbChunkX.Text);
            if (tbChunkY.Text != "-" &&  tbChunkY.Text != "" && int.TryParse(tbChunkY.Text, out n))
                y = int.Parse(tbChunkY.Text);

            //Converts chunks coordinates to file coordinates.
            if (x < 0)
                x = (x+1) / 32 - 1;
            else
                x /= 32;
            if (y < 0)
                y = (y+1) / 32 - 1;
            else
                y /= 32;

            //Create file name that it assigns to label.
            // ( r.X.Y.mca )
            lblFile.Text = "r." + x + "." + y + ".mca";
        }
    }
}
