using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacumRobots.PositonClass
{
    public class EastPositon : BasePositon, IPositon
    {
        public EastPositon(IRobot robot) : base(robot) { }
        public string CurrentPositon() { return this.GetCurrentPosition().ToString(); }
        public IRobot Robot { get { return robot; } set { robot = value; } }

        public void Left()
        {
            base.robot.Positon = PostionFactory.GeneratePositon(robot, PositonEnum.N);
        }

        public void Move()
        {
            base.robot.X = robot.RoomSize.X >= robot.X + 1 ? robot.X + 1 : robot.X;
        }

        public void Right()
        {
            base.robot.Positon = PostionFactory.GeneratePositon(robot, PositonEnum.S);
        }
    }
}
