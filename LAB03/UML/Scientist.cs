using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class Scientist : Human
    {
        private Equipment? equipment;
        public Scientist(Equipment? equipment)
        {
            this.equipment = equipment;
        }

        public void Work(double time)
        {
            if(time < 24)
            {
                return;
            }
            int equipmentToUse = (int)time % 24;
            for(int i = 0; i < equipmentToUse; i++)
            {
                equipment.GatherData();
            }
        }

    }
}
