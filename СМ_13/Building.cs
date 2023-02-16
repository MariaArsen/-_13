using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СМ_13
{
    class Building
    {
        string adress;
        int length;
        int width;
        int height;

        int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 1500000)
                   length = 1500000;
                else if (value < 0)
                    length = 3000;
                else
                    length = value;
            }
        }
        int Width
        {
            get
            {
                return width;
                
            }
            set
            {
                if (value > 500000)
                    width = 500000;
                else if (value < 0)
                    width = 3000;
                else
                    width = value;
            }
        }
        int Height
        {
            get
            {
                return height;

            }
            set
            {
                if (value > 54000)
                    height = 54000;
                else if (value < 0)
                    height = 3000;
                else
                    height = value;
            }
        }

        public Building(string adress, int length, int width, int height)
        {
            this.adress = adress;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        {
            return $"{adress} {length} {width} {height}";
        }
    }
}
