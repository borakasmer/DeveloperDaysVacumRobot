// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using VacumRobots;

RobotFactory robotFactory = new();

(int width, int height) roomSize = (5, 5);
(int x, int y, string Positon) robotProperties = (1, 2, "K");
IRobot robot1 = robotFactory.CreateRobot(new(roomSize.width, roomSize.height), robotProperties.x, robotProperties.y, robotProperties.Positon.GetPositonEnum());

string moveList = "LMXLMYLRMM";
robot1.MoveRobot(moveList);
Console.WriteLine($"{robot1.X},{robot1.Y},{robot1.Positon.CurrentPositon()}");

/*
(int width, int height) roomSize = (5, 5);
(int x, int y, string Positon) robotProperties = (1, 2, "N");
IRobot robot1 = robotFactory.CreateRobot(new(roomSize.width, roomSize.height), robotProperties.x, robotProperties.y, robotProperties.Positon.GetPositonEnum());

string moveList = "LMLMLMLMM";
robot1.MoveRobot(moveList);
Console.WriteLine($"{robot1.X},{robot1.Y},{robot1.Positon.CurrentPositon()}");

(int width, int height) roomSize2 = (5, 5);
(int x, int y, string Positon) robotProperties2 = (3, 3, "E");
IRobot robot2 = robotFactory.CreateRobot(new(roomSize2.width, roomSize2.height), robotProperties2.x, robotProperties2.y, robotProperties2.Positon.GetPositonEnum());

string moveList2 = "MMRMMRMRRM";
robot2.MoveRobot(moveList2);
Console.WriteLine($"{robot2.X},{robot2.Y},{robot2.Positon.CurrentPositon()}");
*/
Console.ReadLine();

