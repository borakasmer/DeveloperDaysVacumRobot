using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using VacumRobots.PositonClass;

namespace VacumRobots
{
    internal class Robot : IRobot
    {
        private int x;
        private int y;
        private Point roomSize;
        private IPositon positon;

        public Robot(int _x, int _y, Point _roomSize)
        {
            X = _x;
            Y = _y;
            roomSize = _roomSize;
        }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public IPositon Positon { get => positon; set => positon = value; }
        public Point RoomSize { get => roomSize; set => roomSize = value; }
        public void MoveRobot(string moveList)
        {
            moveList.ToList().ForEach(p =>
            {
                switch (p.GetMoveEnum())
                {
                    case MoveEnum.M:
                        Positon.Move();
                        break;
                    case MoveEnum.R:
                        Positon.Right();
                        break;
                    case MoveEnum.L:
                        Positon.Left();
                        break;
                    case MoveEnum.X:
                        Positon.Left180();
                        break;
                    case MoveEnum.Y:
                        Positon.Right180();
                        break;
                    default:
                        throw new ArgumentException("Invalid enum value for command", p.ToString());
                        break;
                };
            });
        }
    }
}
