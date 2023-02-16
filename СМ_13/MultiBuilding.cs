using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СМ_13
{
    sealed class MultiBuilding : Building
    {
        int floor;

        int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value > 18)
                    floor = 18;
                else if (value < 0)
                    floor = 1;
                else
                    floor = value;
            }
        }
        public MultiBuilding(string adress, int length, int width, int height, int floor)
            : base(adress, length, width, height)
        {
            this.Floor = floor;
        }
        public string Print()
        {
            string result = base.Print();
            result += $" {floor}";
            return result;
        }
    }
}
