using System;
using System.Collections.Generic;
using System.Text;

namespace BasX
{
    public class World2d
    {
        /// <summary>
        /// The world's gravitational force.
        /// </summary>
        public double Gravity { get; set; }

        /// <summary>
        /// The list of bodies affected by the world.
        /// </summary>
        public IList<Body2d> Bodies { get; set; }

        private long oldTime;

        public World2d(double gravity = 0)
        {
            Gravity = gravity;
            Bodies = new List<Body2d>();
            oldTime = -1;
        }

        public void Update()
        {
            double deltaTime = UpdateTime();

            Vector2d gravityVector = new Vector2d(0.0, Gravity * deltaTime);

            foreach (Body2d body in Bodies)
            {
                body.ApplyForce(gravityVector);
                body.Update(deltaTime);
            }
        }

        /// <summary>
        /// Updates the previously stored time.
        /// </summary>
        /// <returns>The delta time of the previously stored time.</returns>
        private double UpdateTime()
        {
            if (oldTime == -1)
            {
                oldTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }

            double deltaTime = GetDeltaTime(oldTime);
            oldTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            return deltaTime;
        }

        /// <summary>
        /// Calculates the current delta time.
        /// </summary>
        /// <param name="oldTime">Initial time in milliseconds.</param>
        /// <returns>The difference between the old time and the current time in seconds.</returns>
        private double GetDeltaTime(long oldTime)
        {
            return (DateTimeOffset.Now.ToUnixTimeMilliseconds() - oldTime) / 1000.0;
        }
    }
}
