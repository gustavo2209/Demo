using NUnit.Framework;

namespace TestDemo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestSuma()
        {
            double a = 1;
            double b = 2;

            Demo.Models.Baldor baldor = new Demo.Models.Baldor();

            double result = baldor.Suma(a, b);

            double valorEsperado = 3;
            Assert.AreEqual(valorEsperado, result);
        }

        [Test]
        public void TestResta()
        {
            double a = 1;
            double b = 2;

            Demo.Models.Baldor baldor = new Demo.Models.Baldor();

            double result = baldor.Resta(a, b);

            double valorEsperado = -1;
            Assert.AreEqual(valorEsperado, result);
        }

        [Test]
        public void TestMultiplica()
        {
            double a = 1;
            double b = 2;

            Demo.Models.Baldor baldor = new Demo.Models.Baldor();

            double result = baldor.Multiplica(a, b);

            double valorEsperado = 2;
            Assert.AreEqual(valorEsperado, result);
        }

        [Test]
        public void TestDivide()
        {
            double a = 1;
            double b = 2;

            Demo.Models.Baldor baldor = new Demo.Models.Baldor();

            double result = baldor.Divide(a, b);

            double valorEsperado = 0.5;
            Assert.AreEqual(valorEsperado, result);
        }

    }
}