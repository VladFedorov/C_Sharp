using System;

namespace Lab2_CS
{
    public class Triangle
    {
        public int[] CoordA = new int[2];
        public int[] CoordB = new int[2];
        public int[] CoordC = new int[2];

        private double stringA;
        private double stringB;
        private double stringC;

        private double area;

        public double StringA { get => stringA;}
        public double StringB { get => stringB;}
        public double StringC { get => stringC;}
        public double Area { get => area;}

        public void CalculateSides()
        {
            stringA = Math.Round(Math.Sqrt(Math.Pow((CoordB[0] - CoordA[0]), 2) + (Math.Pow(CoordB[1] - CoordA[0], 2))));
            stringB = Math.Round(Math.Sqrt(Math.Pow((CoordC[0] - CoordB[0]), 2) + (Math.Pow(CoordC[1] - CoordB[0], 2))));
            stringC = Math.Round(Math.Sqrt(Math.Pow((CoordA[0] - CoordC[0]), 2) + (Math.Pow(CoordA[1] - CoordC[0], 2))));
        }

        public void CalculateArea()
        {
            area = StringA * StringB * StringC;
        }

        public bool IsTriangle()
        {
            this.CalculateSides();

            if (StringA + StringB <= StringC || StringB + StringC <= StringA || StringA + StringC <= StringB)
                return false;
            else
                return true;
        }

        override public string ToString()
        {
            return ("WARNING!! ALL VALUES ARE ROUNDED!!" + "\nLength of string A = " + (StringA) +
                "\nLength of string B = " + (StringB) +
                "\nLength of string C = " + (StringC) +
                "\nA Angle’s value = " + Math.Round(Math.Acos((StringB * StringB + StringC * StringC - StringA * StringA) / (2 * StringB * StringC)) * 180 / Math.PI) + " degrees" +
                "\nB Angle’s value = " + Math.Round(Math.Acos((StringA * StringA + StringC * StringC - StringB * StringB) / (2 * StringA * StringC)) * 180 / Math.PI) + " degrees" +
                "\nC Angle’s value = " + Math.Round((Math.Acos((StringB * StringB + StringA * StringA - StringC * StringC) / (2 * StringB * StringA)) * 180) / Math.PI) + " degrees" +
                "\nPerimeter of triangle = " + Math.Round(StringA + StringB + StringC) +
                "\nArea of triangle = " + Math.Round(Area));
        }
    }
}
