using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacumRobots
{
    public enum PositonEnum
    {
        N = 1,
        E = 2,
        W = 3,
        S = 4
    }

    public enum MoveEnum
    {
        M = 1,
        L = 2,
        R = 3
    }

    public static class StringExtension
    {
        public static PositonEnum GetPositonEnum(this string positon)
        {
            return (PositonEnum)System.Enum.Parse(typeof(PositonEnum), positon);
        }
        public static MoveEnum GetMoveEnum(this char positon)
        {
            return (MoveEnum)System.Enum.Parse(typeof(MoveEnum), positon.ToString());
        }
    }
}
