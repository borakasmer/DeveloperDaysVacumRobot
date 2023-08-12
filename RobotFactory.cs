using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacumRobots.PositonClass;

namespace VacumRobots
{
    public class RobotFactory
    {
        private int x;
        private int y;
        private Point roomSize;
        private PositonEnum positon;
        public RobotFactory() { }

        public IRobot CreateRobot(Point _roomSize, int _x, int _y, PositonEnum _positon)
        {
            x = _x;
            y = _y;
            positon = _positon;
            roomSize = _roomSize;
            IRobot robot = new Robot(x, y, roomSize);
            robot.Positon = PostionFactory.GeneratePositon(robot, positon);
            return robot;
        }
    }
}
