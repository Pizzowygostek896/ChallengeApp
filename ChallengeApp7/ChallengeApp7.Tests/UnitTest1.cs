using ChallengeApp6;

namespace ChallengeApp7.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // arrange
            var employee = new ChallengeApp6.Employee("Robert", "aliucbwc");
            employee.AddScore(7);
            employee.AddScore(9);

            // act
            int result = employee.Result;

            //assert
            Assert.AreEqual(16, result);
        }




    }
}
