namespace FigureTests
{
    [TestClass]
    public class TestOfFigure
    {
        [TestMethod]
        public void Get_Figures_Name_And_Area()
        {
            Figure triangle = new Triangle("Треугольник", 5, 7, 9);
            Figure triangle2 = new Triangle("Треугольник", 7, 24, 25);
            Figure circle = new Circle("Круг", -4);

            List<Figure> listFigures = new List<Figure> { triangle, triangle2, circle};

            List<string> namesFigures = new List<string>
            {
                "Треугольник",
                "Прямоугольный Треугольник",
                "Круг"
            };

            List<double> areasFigures = new List<double>
            {
                17.41228,
                84,
                50.265482
            };

            int i = 0;
            foreach (Figure f in listFigures)
            {
                Assert.AreEqual($"Тип фигуры: {namesFigures[i]}, Площадь: {areasFigures[i]}", $"Тип фигуры: {f.Name}, Площадь: {f.GetArea()}");
                i++;
            }
        }
    }
}
