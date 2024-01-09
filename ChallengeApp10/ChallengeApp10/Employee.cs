namespace ChallengeApp10
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
            int valueInInt = (int)grade;
            float f = valueInInt;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }

            else
            {
                Console.WriteLine("Wrong grade value");
            }
        }
        
        public void AddGrade(string grade)
        {

            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }

            else
            {
                Console.WriteLine("String is not float");
            }
        }
        
        public void AddGrade(double grade)
            {
                float gradeToFloat = (float)grade;
                this.AddGrade(gradeToFloat);
            }
        
        
        public void AddGrade(long grade)
            {
                float gradeToLong = (long)grade;
                this.AddGrade(gradeToLong);
            }
        
        public void AddGrade(int grade)
        {
            float gradeToInt = (int)grade;
                    this.AddGrade(gradeToInt); 
        }
    }
}

















