using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftChunkPriorityCalculator.Objects
{
    class Chunk
    {
        private int X { get; set; }
        private int Y { get; set; }

        public string getFileName()
        {
            //Sets x and y to chunk coordinates.
            int x = this.X;
            int y = this.Y;

            //Converts chunks coordinates to file coordinates.
            if (x < 0)
                x = (x + 1) / 32 - 1;
            else
                x /= 32;
            if (y < 0)
                y = (y + 1) / 32 - 1;
            else
                y /= 32;

            //Create file name that it assigns to label.
            // ( r.X.Y.mca )
            return "r." + x + "." + y + ".mca";
        }
        public static string getFileName(int x, int y)
        {
            //Converts chunks coordinates to file coordinates.
            if (x < 0)
                x = (x + 1) / 32 - 1;
            else
                x /= 32;
            if (y < 0)
                y = (y + 1) / 32 - 1;
            else
                y /= 32;

            //Create file name that it assigns to label.
            // ( r.X.Y.mca )
            return "r." + x + "." + y + ".mca";
        }

        public static string playerToChunk(string coord)
        {
            //Checks if input(coords) might cause errors when converting to int.
            if (coord == null || coord == "" || coord == "-")
                return "0";
            //Instances output variable.
            string output = "";
            //Converts string input into integer.
            int value = int.Parse(coord);

            //Ajusts for negative values.(Probably not the best way)
            if (value < 0)
                output += (value / 16 - 1).ToString();
            else
                output += (value / 16).ToString();
            return output;
        }

        public Chunk(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
