using System;

namespace BasX
{
    public class Vector
    {
        protected double[] Components { get; private set; }

        protected Vector(int dimensions)
        {
            Components = new double[dimensions];
        }

        /// <summary>
        /// Adds another vector to this one.
        /// </summary>
        /// <param name="other">The vector to be added.</param>
        /// <returns>The resultant vector.</returns>
        protected Vector Add(Vector other)
        {
            int minComponents = Math.Min(Components.Length, other.Components.Length);

            for (int i = 0; i < minComponents; i++)
            {
                Components[i] += other.Components[i];
            }

            return this;
        }

        /// <summary>
        /// Multiplies a scalar to this vector.
        /// </summary>
        /// <param name="scalar">The scalar to multiply by.</param>
        /// <returns>The resultant vector.</returns>
        protected Vector Scale(double scalar)
        {
            for (int i = 0; i < Components.Length; i++)
            {
                Components[i] *= scalar;
            }

            return this;
        }
    }
}
