using System;
using System.Collections.Generic;
using System.Text;

namespace BasX
{
    public class Vector2d : Vector
    {
        public double X
        {
            get { return Components[0]; }
            set { Components[0] = value; }
        }

        public double Y
        {
            get { return Components[1]; }
            set { Components[1] = value; }
        }

        public Vector2d() : base(2)
        {
        }

        public Vector2d(double x, double y) : this()
        {
            X = x;
            Y = y;
        }

        public Vector2d Add(Vector2d other)
        {
            return (Vector2d)base.Add(other);
        }

        public new Vector2d Scale(double scalar)
        {
            return (Vector2d) base.Scale(scalar);
        }
    }
}
