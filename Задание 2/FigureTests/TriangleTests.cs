namespace FigureTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Calculate_Triangle_Aria1()
        {
            Triangle triangle = new Triangle("Треугольник", 4, 6, 8);
            Assert.AreEqual(11.61895, triangle.GetArea());
        }

        [TestMethod]
        public void Calculate_Triangle_Aria2()
        {
            Triangle triangle = new Triangle("Треугольник", 95.44453, 99.2343, 84.34523);
            Assert.AreEqual(3696.03798, triangle.GetArea());
        }

        [TestMethod]
        public void Calculate_Triangle_Aria3()
        {
            Triangle triangle = new Triangle("Треугольник", 7.45, 9245.753, 6742.7533);
            Assert.AreEqual(double.NaN, triangle.GetArea());
        }

        [TestMethod]
        public void Calculate_Triangle_Aria4()
        {
            Triangle triangle = new Triangle("Треугольник", 0, 0, 0);
            Assert.AreEqual(0, triangle.GetArea());
        }

        [TestMethod]
        public void Calculate_Triangle_Aria5()
        {
            Triangle triangle = new Triangle("Треугольник", -5, -8, -6.45);
            Assert.AreEqual(16.111869, triangle.GetArea());
        }
        [TestMethod]
        public void Triangle_Type1()
        {
            string nameTriangle = "Треугольник";
            Triangle triangle = new Triangle(nameTriangle, 7, 24, 25);
            Assert.AreEqual($"Прямоугольный {nameTriangle}", triangle.Name);
        }

        [TestMethod]
        public void Triangle_Type2()
        {
            string nameTriangle = "Треугольник";
            Triangle triangle = new Triangle(nameTriangle, 3.43, 6.45, 8.43);
            Assert.AreEqual(nameTriangle, triangle.Name);
        }
    }
}