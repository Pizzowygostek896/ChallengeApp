using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp8.Tests
{
    internal class TypeTest
    {
        [Test]
        public void Test1()
        {
            // arrange
            string number1 = "Adam";
            string number2 = "Adam";

            // assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void Test2()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // assert
            Assert.AreNotEqual(user1, user2);
        }
        [Test]
        public void Test3()
        {
            // arrange
            int number1 = 4;
            int number2 = 5;
            
            // assert
            Assert.AreNotEqual(number1, number2);
        }
        public User GetUser(string name)
        {
            return new User(name);

        }
        
    }
}
