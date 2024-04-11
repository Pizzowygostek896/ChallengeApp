
namespace ChallengeApp11._1
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
        public void AddGrades(int grades)
        {
            float gradesToInt = (int)grades;
            this.AddGrade(gradesToInt);
        }

        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            
            foreach (var grade in this.grades)
                for (int i = 0; i < grades.Count; i++)
                {
                    float v = grades[i];
                    statistics.Max = Math.Max(statistics.Max, (float)v);
                    statistics.Min = Math.Min(statistics.Min, (float)v);
                    statistics.Average += (float)v;
                    if ((float)v >= 0)
                    {
                        statistics.Max = Math.Max(statistics.Max, (float)v);
                        statistics.Min = Math.Min(statistics.Min, (float)v);
                        statistics.Average += (float)v;
                    }
                }
            statistics.Average = statistics.Average / grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            statistics.Average = statistics.Average / this.grades.Count;
            for (int grade = 0; grade < grades.Count; grade++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++;
            }
            statistics.Average = statistics.Average / grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            while (index < grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++;
            }
            statistics.Average = statistics.Average / grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }
    }
}

