namespace ChallengeApp7
{
    
    
         public class Employee
        {
            private List<int> score = new List<int>();
        private string v1;
        private string v2;

        public Employee(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Employee(string name, string surname, int age)
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

        }
}


