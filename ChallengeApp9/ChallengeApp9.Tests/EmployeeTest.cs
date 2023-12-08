namespace ChallengeApp9.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsIsCalled_ShouldReturnCorrectMinValue()
        {
            //arrange
            var employee = new Employee("Aleksy", "Prokredor");
            employee.AddGrade(5);
            employee.AddGrade(14);
            employee.AddGrade(9);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(5, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsIsCalled_ShouldReturnCorrectMaxValue()
        {
            //arrange
            var employee = new Employee("Aleksy", "Luksiejowski");
            employee.AddGrade(9);
            employee.AddGrade(25);
            employee.AddGrade(16);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreNotEqual(25, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsIsCalled_ShouldReturnCorrectAverageValue()
        {
            //arrange
            var employee = new Employee("Aleksy", "Sobitanowski");
            employee.AddGrade(11);
            employee.AddGrade(10);
            employee.AddGrade(5);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreNotEqual(10, statistics.Average);
        }
    }
}
