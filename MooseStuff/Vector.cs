using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni
{
    class Vector
    {
        public static Vector Origin = new Vector(0, 0);
        public const float UNIT_X = 1.0f;
        public const float UNIT_Y = 1.0f;

        public float x;
        public float y;
        public float Mag
        {
            get
            {
                return (float) (180 * Math.Sqrt(x * x + y * y) / (2 * Math.PI));
            }
        }
        public float Angle
        {
            get
            {
                return (float)(180 * Math.Atan(y / x) / (2 * Math.PI));
            }
        }

        public Vector() : this(0, 0)
        {
        }

        public Vector(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Set(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Add(Vector Other)
        {
            Add(Other.x, Other.y);
        }

        public void Add(float x, float y)
        {
            this.x += x;
            this.y += y;
        }

        public void Sub(Vector Other)
        {
            Sub(Other.x, Other.y);
        }

        public void Sub(float x, float y)
        {
            this.x -= x;
            this.y -= y;
        }

        public void Mult(float Scalar)
        {
            x *= Scalar;
            y *= Scalar;
        }

        public void Div(float Scalar)
        {
            x /= Scalar;
            y /= Scalar;
        }

        public static Vector Add(Vector Vec1, Vector Vec2)
        {
            return new Vector(Vec1.x + Vec2.x, Vec1.y + Vec2.y);
        }

        public static Vector Sub(Vector Vec1, Vector Vec2)
        {
            return new Vector(Vec1.x - Vec2.x, Vec1.y - Vec2.y);
        }

        public static Vector Mult(Vector Vec, float Scalar)
        {
            return new Vector(Vec.x * Scalar, Vec.y * Scalar);
        }

        public static Vector Div(Vector Vec, float Scalar)
        {
            return new Vector(Vec.x / Scalar, Vec.y / Scalar);
        }
    }
}
