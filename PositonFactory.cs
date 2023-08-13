using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacumRobots.PositonClass;

namespace VacumRobots
{
    public static class PostionFactory
    {
        private static Dictionary<string, IPositon> PostionStorage = new Dictionary<string, IPositon>();

        public static IPositon GeneratePositon(IRobot robot, PositonEnum postionType)
        {
            if (PostionStorage.TryGetValue(postionType.ToString(), out var positon))
            {              
                positon.Robot = robot;
                return positon;
            }
            else
            {
                var newPositon = CreatePositon(postionType, robot);
                PostionStorage.Add(postionType.ToString(), newPositon);
                return newPositon;
            }
        }
        public static IPositon CreatePositon(PositonEnum postion, IRobot robot)
        {
            return postion switch
            {
                PositonEnum.W => new WestPositon(robot),
                PositonEnum.N => new NorthPositon(robot),
                PositonEnum.E => new EastPositon(robot),
                PositonEnum.S => new SouthPositon(robot),
                PositonEnum.Y => new NorthEastPositon(robot),
                PositonEnum.T => new NorthWestPositon(robot),
                PositonEnum.K => new SouthEastPositon(robot),
                PositonEnum.L => new SouthWestPositon(robot),
            };
        }
    }
}
