using MinecraftChunkPriorityCalculator.Objects;
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
            tbChunkX.Text = Chunk.playerToChunk(tbPlayerX.Text);
        }

        private void tbPlayerY_TextChanged(object sender, EventArgs e)
        {
            tbChunkY.Text = Chunk.playerToChunk(tbPlayerY.Text);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            if (!isNumber(tbChunkX.Text) || !isNumber(tbChunkY.Text))
                return;
            int x = int.Parse(tbChunkX.Text);
            int y = int.Parse(tbChunkY.Text);
            lblPriority.Text = Utils.calculatePriority(x,y);
            lblFile.Text = Chunk.getFileName(x, y);
        }

        private bool isNumber(string a)
        {
            if (a != "-" && a != "" && int.TryParse(a, out int n))
                return true;
            return false;
        }

        private void openMapViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon");
            //MapView map = new MapView();
        }
    }
}
