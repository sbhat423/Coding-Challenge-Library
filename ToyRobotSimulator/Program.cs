using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ToyRobotSimulatorLib;

namespace ToyRobotSimulatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var robot = new Robot();
            var table = new TableTop();

            var robotController = new RobotController(robot);

            Console.WriteLine("Test1..");
            List<string> test1 = File.ReadAllLines(@"..\..\TestInputs\Test1.txt").ToList<string>();

            foreach (string command in test1)
                Console.WriteLine(command);
            robotController.ReadCommand(test1);

            Console.WriteLine("\nTest2..");
            List<string> test2 = File.ReadAllLines(@"..\..\TestInputs\Test2.txt").ToList<string>();

            foreach (string command in test2)
                Console.WriteLine(command);
            robotController.ReadCommand(test2);

            Console.WriteLine("\nTest3..");
            List<string> test3 = File.ReadAllLines(@"..\..\TestInputs\Test3.txt").ToList<string>();

            foreach (string command in test3)
                Console.WriteLine(command);
            robotController.ReadCommand(test3);

            Console.ReadLine();
        }
    }
}
