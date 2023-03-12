namespace FigureTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Calculate_Circle_Aria1()
        {
            Circle circle = new Circle("Круг", 4);
            Assert.AreEqual(50.265482, circle.GetArea());
        }

        [TestMethod]
        public void Calculate_Circle_Aria2()
        {
            Circle circle = new Circle("Круг", 356.435);
            Assert.AreEqual(399126.49509, circle.GetArea());
        }

        [TestMethod]
        public void Calculate_Circle_Aria3()
        {
            Circle circle = new Circle("Круг", 0);
            Assert.AreEqual(0, circle.GetArea());
        }

        [TestMethod]
        public void Calculate_Circle_Aria4()
        {
            Circle circle = new Circle("Круг", -5);
            Assert.AreEqual(78.539816, circle.GetArea());
        }

        [TestMethod]
        public void Circle_Type()
        {
            string nameCircle = "Круг";
            Circle circle = new Circle(nameCircle, 75);
            Assert.AreEqual("Круг", circle.Name);
        }

        [TestMethod]
        public void Calculate_GetRadius()
        {
            Circle circle = new Circle("Круг", -5);
            Assert.AreEqual(5, circle.Radius);
        }
    }
}
