using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacumRobots.PositonClass
{
    public class NorthWestPositon : BasePositon, IPositon
    {
        public NorthWestPositon(IRobot robot) : base(robot) { }
        public string CurrentPositon() { return this.GetCurrentPosition().ToString(); }
        public IRobot Robot { get { return robot; } set { robot = value; } }
        public void Left()
        {
            base.robot.Positon = PostionFactory.GeneratePositon(robot, PositonEnum.L);
        }

        public void Move()
        {
            base.robot.Y = robot.RoomSize.Y >= robot.Y + 1 ? robot.Y + 1 : robot.Y;
            base.robot.X = robot.X - 1 > 0 ? robot.X - 1 : robot.X;
        }

        public void Right()
        {
            base.robot.Positon = PostionFactory.GeneratePositon(robot, PositonEnum.Y);
        }

      
        public void Left180()
        {
            base.robot.Positon = PostionFactory.GeneratePositon(robot, PositonEnum.K);
        }
        public void Right180()
        {
            base.robot.Positon = PostionFactory.GeneratePositon(robot, PositonEnum.K);
        }
    }
}
