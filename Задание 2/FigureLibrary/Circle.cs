namespace FigureLibrary
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(string name, double radius) : base(name)
        {
            Name = name;
            Radius = Math.Abs(radius);
        }

        public override double GetArea()
        {
            return Math.Round(Math.Pow(Radius, 2) * Math.PI, 6);
        }
    }
}
