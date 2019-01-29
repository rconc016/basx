using System;
using BasX;

namespace BasXConsoleApp
{
    /// <summary>
    /// Simple console application to test BasX functionality.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            World2d world = new World2d(9.8);
            Body2d body = new Body2d();

            world.Bodies.Add(body);

            Console.WriteLine("Press Enter to start simulation...");
            Console.ReadLine();

            while (true)
            {
                world.Update();

                if (body.Position.Y < 0)
                {
                    body.Position.Y = 0;
                    body.Velocity.Y = 0;
                    body.Acceleration.Y = 0;
                }

                Console.WriteLine($"Body Velocity: ({body.Velocity.X}, {body.Velocity.Y})");
                Console.WriteLine($"Body Position: ({body.Position.X}, {body.Position.Y})");
                Console.WriteLine($"Body Acceleration: ({body.Acceleration.X}, {body.Acceleration.Y})");
                Console.WriteLine();
            }
        }
    }
}
