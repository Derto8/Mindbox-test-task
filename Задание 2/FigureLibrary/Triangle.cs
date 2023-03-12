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

            //определяем по теореме Пифагора, является ли треугольник прямоугольным
            List<double> list = new List<double> { A, B, C };
            list = list.OrderByDescending(x => x).ToList();

            if (Math.Pow(list[1], 2) + Math.Pow(list[2], 2) == Math.Pow(list[0], 2))
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
