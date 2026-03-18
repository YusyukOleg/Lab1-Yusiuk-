using Microsoft.VisualStudio.TestTools.UnitTesting;
using HumanLibrary;

namespace HumanLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateBmi_NormalValues()
        {
            Person testPerson = new Person(20, "Чоловік", 1.80, 75.0, "Українець", "Християнство", "Студент", "АА123456");

            double expectedBmi = 75.0 / (1.80 * 1.80);

            double actualBmi = testPerson.CalculateBmi();

            Assert.AreEqual(expectedBmi, actualBmi, 0.001, "Індекс маси тіла розраховано неправильно!");
        }

        [TestMethod]
        public void TestCalculateBmi_ZeroHeight_ReturnsZero()
        {
            Person testPerson = new Person(20, "Чоловік", 0.0, 75.0, "Українець", "Християнство", "Студент", "АА123456");

            double actualBmi = testPerson.CalculateBmi();

            Assert.AreEqual(0, actualBmi, "Якщо зріст дорівнює 0, ІМТ також має дорівнювати 0.");
        }
    }
}