using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp8
{
    public class getUser
    {
        private List<int> score = new List<int>();


        public getUser(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }

        }
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
        public void RemoveScore(int number)
        {
            this.score.Add(number);
        }

        public void Multiplication(int number)
        {
            this.score.Add(number);
        }


    }
}
