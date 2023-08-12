using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacumRobots.PositonClass;

namespace VacumRobots
{
    public interface IRobot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public IPositon Positon { get; set; }
        public Point RoomSize { get; set; }
        public void MoveRobot(string moveList);
    }
}
