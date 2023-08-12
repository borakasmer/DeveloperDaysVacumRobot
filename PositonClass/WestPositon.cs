using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VacumRobots.PositonClass
{
    public class WestPositon : BasePositon, IPositon
    {
        public WestPositon(IRobot robot) : base(robot) { }
        public string CurrentPositon() { return this.GetCurrentPosition().ToString(); }
        public IRobot Robot { get { return robot; } set { robot = value; } }
        public void Left()
        {
            base.robot.Positon = PostionFactory.GeneratePositon(robot, PositonEnum.S);
        }

        public void Move()
        {
            base.robot.X = robot.X - 1 >= 0 ? robot.X - 1 : robot.X;
        }

        public void Right()
        {
            base.robot.Positon = PostionFactory.GeneratePositon(robot, PositonEnum.N);
        }
    }
}
