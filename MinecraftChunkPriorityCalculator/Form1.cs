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
            tbPlayerX.Text = "0";
            tbPlayerY.Text = "0";
            tbChunkX.Text = "0";
            tbChunkY.Text = "0";
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
        /// Signed binaries:
        /// first bit is the sign 0 for positive, 1 for negative.
        /// next 8 are for exponent
        /// last 23 are mantis
        /// 0 00000000 00000000000000000000000
        /// </summary>
        private void calculatePriority()
        {

            if (tbChunkX.Text != null && tbChunkX.Text != "" && tbChunkX.Text != "-" && tbChunkY.Text != null && tbChunkY.Text != "" && tbChunkY.Text != "-")
            {
                
                String x = Convert.ToString(int.Parse(tbChunkX.Text), 2);
                String y = Convert.ToString(int.Parse(tbChunkY.Text), 2);
                string xor1 = xorStrings(x, y).PadLeft(32,'0');
                string[] table = splitInHalf(xor1);
                string a = table[0];
                string b = table[1];
                string xor2 = xorStrings(a, b);


                
                int priority = Convert.ToInt32(xor2, 2);
                lblPriority.Text = priority.ToString();

            }
        }
        private string xorStrings(string a, string b)
        {
            string output = "";
            int len = Math.Max(a.Length, b.Length);
            a = a.PadLeft(len, '0');
            b = b.PadLeft(len, '0');

            for (int i = 0; i < len; i++)
            {
                output += a[i] == b[i] ? '0' : '1';
            }
            return output;
        }
        private string[] splitInHalf(string input)
        {
            string[] output = new string[2];
            for (int i = 0; i < input.Length/2; i++)
            {
                output[0] += input[i];
                output[1] += input[input.Length/2 + i];
            }
            return output;
        }
        private string playerToChunk(string coords)
        {
            if (coords == null || coords == "" || coords == "-")
                return "0";
            string output ="";
            int value = int.Parse(coords);
            output += (value / 16).ToString();
            return output;
        }

        private void getFileName()
        {
            int x = 0;
            int y = 0;
            if (tbChunkX.Text != "")
                x = int.Parse(tbChunkX.Text);
            if (tbChunkY.Text != "")
                y = int.Parse(tbChunkY.Text);
            lblFile.Text = "r." + (x / 512) + "." + (y / 512) + ".mca";
        }
    }
}
