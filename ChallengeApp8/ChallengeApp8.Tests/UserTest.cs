using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp8.Tests
{
    public class UserTests
    {


        [Test]
        public void Testx()
        {
            //arrange
            var user = new getUser("Romek", "Subierzański", 40);
            user.AddScore(3);
            user.AddScore(11);
            user.RemoveScore(-13);
            user.Multiplication(2 * 6);


            //act
            var result = user.Result;


            //assert
            Assert.AreNotEqual(12, result);

            



        }
    }
}
