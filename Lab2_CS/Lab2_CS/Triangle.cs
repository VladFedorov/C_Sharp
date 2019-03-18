using System;

namespace Lab2_CS
{
    internal class Triangle
    {
            public int[] CoordA = new int[2];

            public int[] CoordB = new int[2];

            public int[] CoordC = new int[2];

            public int StringA;

            public int StringB;

            public int StringC;

            public void Input()
            {

                

            }
            public virtual void Check()
            {
            StringA = Convert.ToInt32(Math.Sqrt(Math.Pow((CoordB[0] - CoordA[0]), 2) + (Math.Pow(CoordB[1] - CoordA[0],2))));

            StringB = Convert.ToInt32(Math.Sqrt(Math.Pow((CoordC[0] - CoordB[0]), 2) + (Math.Pow(CoordC[1] - CoordB[0],2))));

            StringC = Convert.ToInt32(Math.Sqrt(Math.Pow((CoordA[0] - CoordC[0]), 2) + (Math.Pow(CoordA[1] - CoordC[0], 2))));
            if (StringA + StringB < StringC && StringB + StringC < StringA && StringA + StringC < StringB)
                {
                    Console.WriteLine("This triangle is impossible");
                    Input();
                } 
            }
            public string Output()
            {
            return ("Length of string A = " + StringA + "\nLength of string B = " + StringB + "\nLength of string C = " + StringC + "\nA Angle’s value = " + Math.Round((Math.Cos(Convert.ToDouble((Math.Pow(StringB, 2) + Math.Pow(StringC, 2) - Math.Pow(StringA, 2)) / (2 * StringB * StringC)))),2)+ " degrees" + "\n B Angle’s value = " + Math.Round((Math.Cos(Convert.ToDouble((Math.Pow(StringA, 2) + Math.Pow(StringC, 2) - Math.Pow(StringB, 2)) / (2 * StringA * StringC)))),3) + " degrees" + "\n C Angle’s value = " + Math.Round((Math.Cos(Convert.ToDouble((Math.Pow(StringB, 2) + Math.Pow(StringA, 2) - Math.Pow(StringC, 2)) / (2 * StringB * StringA)))),2) + " degrees" + "\nPerimeter of triangle = " + (StringA + StringB + StringC) + "\nArea of triangle = " + (StringA * StringB * StringC));
        }
        public class RightTriangle : Triangle
            {
                public override void Check()
                {
                    base.Check();
                    if (StringA * StringA + StringB * StringB == StringC || StringC * StringC + StringB * StringB == StringA || StringA * StringA + StringC * StringC == StringB)
                    {
                        Console.WriteLine("This triangle is right");
                    }
                }
            }
    }
}
