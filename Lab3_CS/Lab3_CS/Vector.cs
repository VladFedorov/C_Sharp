using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CS
{
    public class Vector
    {
        public int coordx;
        public int coordy;
        public int coordz;
        private bool colinearity;

        public Vector(int b, int c, int d)
        {
            coordx = b;
            coordy= c;
            coordz = d;
        }
        public Vector()
        {
        }

        public static Vector operator +(Vector vector1, Vector vector2)
        {
            return new Vector() { coordx = vector1.coordx + vector2.coordx , coordy = vector1.coordy + vector2.coordy, coordz = vector1.coordz + vector2.coordz };
        }
        public static Vector operator &(Vector vector1, Vector vector2)
        {
            return new Vector() { coordx = vector1.coordx * vector2.coordx, coordy = vector1.coordy * vector2.coordy, coordz = vector1.coordz * vector2.coordz };
        }

        public static Vector operator *(Vector vector1, Vector vector2)
        {
            return new Vector() { coordx = vector1.coordy * vector2.coordz - vector1.coordz * vector2.coordy, coordy = vector1.coordz * vector2.coordx - vector1.coordx * vector2.coordz, coordz = vector1.coordx * vector2.coordy - vector1.coordy * vector2.coordx };
        }
        public static Vector operator |(Vector vector1, Vector vector2)
        {
            if(vector2.coordx/vector1.coordx == vector2.coordy/vector1.coordy  && vector2.coordy / vector1.coordy == vector2.coordz/vector1.coordz)
            {
                return new Vector() {colinearity = true };
            }
            return new Vector() { colinearity = false };
        }

        public string tostring(Vector vector1, Vector vector2, Vector vector3, Vector vector4, Vector vector5, Vector vector6)
        {
            return ("VectorSumm" + "\t(" + vector3.coordx + ";" + vector3.coordy + ";" + vector3.coordz + ")" +
                "\nscalar product\t" + vector4.coordx + vector3.coordy + vector3.coordz +
                "\nVector product\t" + "(" + vector5.coordx + ";" + vector5.coordy + ";" + vector5.coordz + ")" +
                "\nColinearity\t" + vector6.colinearity);
        }

    }

}
