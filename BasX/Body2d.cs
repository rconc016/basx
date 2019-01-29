using System;
using System.Collections.Generic;
using System.Text;

namespace BasX
{
    public class Body2d
    {
        public Vector2d Position { get; set; }
        public Vector2d Velocity { get; set;  }
        public Vector2d Acceleration { get; set; }
        public double Mass { get; set; }

        public Body2d()
        {
            Position = new Vector2d();
            Velocity = new Vector2d();
            Acceleration = new Vector2d();
            Mass = 1.0;
        }

        /// <summary>
        /// Updates the body's physical properties.
        /// </summary>
        /// <param name="deltaTime">The amount time in seconds since the last update.</param>
        public void Update(double deltaTime)
        {
            Vector2d scaledAcceleration = new Vector2d(Acceleration.X * deltaTime, Acceleration.Y * deltaTime);

            Velocity.Add(scaledAcceleration);

            Position.Add(Velocity);
        }

        /// <summary>
        /// Applies a force vector to this body.
        /// </summary>
        /// <param name="force">The force vector to apply.</param>
        public void ApplyForce(Vector2d force)
        {
            Vector2d scaledForce = new Vector2d(force.X, force.Y);
            scaledForce.Scale(1.0 / Mass);

            Acceleration.Add(scaledForce);
        }
    }
}
