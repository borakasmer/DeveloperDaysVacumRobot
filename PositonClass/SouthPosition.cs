using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacumRobots.PositonClass
{
    public class SouthPositon : BasePositon, IPositon
    {
        public SouthPositon(IRobot robot) : base(robot) { }
        public string CurrentPositon() { return this.GetCurrentPosition().ToString(); }
        public IRobot Robot { get { return robot; } set { robot = value; } }
        public void Left()
        {
            base.robot.Positon = PostionFactory.GeneratePositon(robot, PositonEnum.E);
        }

        public void Move()
        {
            base.robot.Y = robot.Y - 1 >= 0 ? robot.Y - 1 : robot.Y;
        }

        public void Right()
        {
            base.robot.Positon = PostionFactory.GeneratePositon(robot, PositonEnum.W);
        }
        public void Left180()
        {
            base.robot.Positon = PostionFactory.GeneratePositon(robot, PositonEnum.N);
        }
        public void Right180()
        {
            base.robot.Positon = PostionFactory.GeneratePositon(robot, PositonEnum.N);
        }
    }
}
