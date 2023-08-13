using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacumRobots.PositonClass
{
    public class BasePositon
    {
        public IRobot robot;
        public BasePositon(IRobot _robot) { robot = _robot; }
        public PositonEnum GetCurrentPosition()
        {
            return robot.Positon switch
            {
                WestPositon => PositonEnum.W,
                NorthPositon => PositonEnum.N,
                EastPositon => PositonEnum.E,
                SouthPositon => PositonEnum.S,
                NorthEastPositon => PositonEnum.Y,
                NorthWestPositon => PositonEnum.T,
                SouthEastPositon => PositonEnum.K,
                SouthWestPositon => PositonEnum.L,
            };
        }
    }
}
