using Newtonsoft.Json.Linq;
using CoffeeShopConsoleAppNet60;

namespace CoffeeTeat
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CoffeeTest()
        {


        }
        // iligemed den korrekte pris
        // .
        [DataTestMethod]
        [DataRow(40)]
        [TestMethod]
        public void LatteErILigmed40(int value)
        {
            // Arrange
            var latte = new Latte();
            // Act
            int price = latte.Price();
            // Assert
            Assert.AreEqual(value, price);
        }
        [DataTestMethod]
        [DataRow(20)]
        [TestMethod]
        public void SortKaffeErILigemed20(int value)
        {
            // Arrange
            var blackCoffee = new BlackCoffee();
            // Act
            int price = blackCoffee.Price();
            // Assert
            Assert.AreEqual(value, price);
        }
        [DataTestMethod]
        [DataRow(25)]
        [TestMethod]
        public void CortadoPrisErIligmed25(int value)
        {
            // Arrange
            var coratdo = new Cortado();
            // Act
            int price = coratdo.Price();
            // Assert
            Assert.AreEqual(value, price);
        }
       

        
        // Er iligemed to af de korrekte tal af mælk
        [DataTestMethod]
        [DataRow(200)]
        [TestMethod]
        public void LatteMælkErILigemed200(int value)
        {
            // Arrange
            var latte = new Latte();
            // Act
            int mlMilk = latte.MlMilk();
            // Assert
            Assert.AreEqual(value, mlMilk);
        }
        [DataTestMethod]
        [DataRow(0)]
        [TestMethod]
        public void SortKaffeErIligemed0(int value)
        {
            // Arrange
            var blackCoffee = new BlackCoffee();
            // Act
            int mlMilk = blackCoffee.MlMilk();
            // Assert
            Assert.AreEqual(value, mlMilk);
        }
        [DataTestMethod]
        [DataRow(40)]
        [TestMethod]
        public void CortadoMælkErILigemd40(int value)
        {
            // Arrange
            var cortado = new Cortado();
            // Act
            int mlMilk = cortado.MlMilk();
            // Assert
            Assert.AreEqual(value, mlMilk);
        }
        

        // Eqaul til den korrekte kaffe
        [DataTestMethod]
        [DataRow("Latte")]
        [TestMethod]
        public void LatteKaffeTypeErIligmedLatte(string value)
        {
            // Arrange
            var latte = new Latte();
            // Act
            string coffeType = latte.CoffeeType();
            // Assert
            Assert.AreEqual(value, coffeType);
        }
        [DataTestMethod]
        [DataRow("Black Coffee")]
        [TestMethod]
        public void BSortKaffeKaffeTypeErILigmedSortKaffe(string value)
        {
            // Arrange
            var blackCoffee = new BlackCoffee();
            // Act
            string coffeType = blackCoffee.CoffeeType();
            // Assert
            Assert.AreEqual(value, coffeType);
        }
        [DataTestMethod]
        [DataRow("Cortado")]
        [TestMethod]
        public void CortadoKaffeTypeErIligmedCortado(string value)
        {
            // Arrange
            var cortado = new Cortado();
            // Act
            string coffeType = cortado.CoffeeType();
            // Assert
            Assert.AreEqual(value, coffeType);
        }
        

        // Iligmed den korrekte mælk
        [DataTestMethod]
        [DataRow("Weak")]
        [TestMethod]
        public void StyrkeErIligmedsvagLatte(string value)
        {
            // Arrange
            var latte = new Latte();
            // Act
            string coffeType = latte.Strength();
            // Assert
            Assert.AreEqual(value, coffeType);
        }
        [DataTestMethod]
        [DataRow("Strong")]
        [TestMethod]
        public void SortKaffeStyrkeErILigmedsSærktKaffe(string value)
        {
            // Arrange
            var blackCoffee = new BlackCoffee();
            // Act
            string coffeType = blackCoffee.Strength();
            // Assert
            Assert.AreEqual(value, coffeType);
        }
        [DataTestMethod]
        [DataRow("Medium")]
        [TestMethod]
        public void CortadoStyrkeErIligmedMediumCortado(string value)
        {
            // Arrange
            var cortado = new Cortado();
            // Act
            string coffeType = cortado.Strength();
            // Assert
            Assert.AreEqual(value, coffeType);
        }
        

        // Spørgsmålet her er om det korrekte test er mislykket f


        [DataTestMethod]
        [DataRow(20)]
        [DataRow(15)]
        [DataRow(10)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LatteDiscountPrisErStørreEnd5(int value)
        {
            // Arrange
            var latte = new Latte(value);
            // Act
            int price = latte.Price();
            // Assert

            Assert.AreEqual(40, price);
        }




    }
}
