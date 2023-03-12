namespace FigureLibrary
{
    public class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(string name, double A, double B, double C) : base(name)
        {
            this.A = Math.Abs(A);
            this.B = Math.Abs(B);
            this.C = Math.Abs(C);

            //определение, является ли треугольник прямоугольным по теореме Пифагора
            double LargestSize = 0;
            double size2 = 0;
            double size3 = 0;
            if (A > B && A > C)
            {
                LargestSize = A;
                size2 = B;
                size3 = C;
            }
            if (B > A && B > C)
            {
                LargestSize = B;
                size2 = A;
                size3 = C;
            }
            if (C > A && C > B)
            {
                LargestSize = C;
                size2 = A;
                size3 = B;
            }

            if (Math.Pow(size2, 2) + Math.Pow(size3, 2) == Math.Pow(LargestSize, 2))
                Name = $"Прямоугольный {name}";
            else
                Name = name;
        }

        public override double GetArea()
        {
            double semiPerimeter = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C)), 6);
        }
    }
}
