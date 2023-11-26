using ChallengeApp6;
Employee employee1 = new Employee("Robert", "Pedro", 44);
Employee employee2 = new Employee("Martyna", "Wiermoń", 34);
Employee employee3 = new Employee("Kamil", "Dobrzerski", 35);

employee1.AddScore(7);
employee1.AddScore(14);
employee1.AddScore(3);
employee1.AddScore(11);
employee1.AddScore(2);

employee2.AddScore(1);
employee2.AddScore(9);
employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(3);

employee3.AddScore(8);
employee3.AddScore(1);
employee3.AddScore(6);
employee3.AddScore(11);
employee3.AddScore(12);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

List<Employee> employees2 = new List<Employee>();

int maxValue = -1;
Employee maxScoredEmployee = null;

foreach (var emp in employees)
{
    if (emp.Result > maxValue)
    {
        maxScoredEmployee = emp;
        maxValue = emp.Result;
        employees2.Clear();
    }
    if (emp.Result == maxValue)
    {
        employees2.Add(emp);
    }
}
int counter = employees2.Count;

if (counter > 1)
{
    Console.WriteLine("We have winners:");
    foreach (var emp2 in employees2)
    {
        Console.WriteLine($"{emp2.Name} {emp2.Surname} age: {emp2.Age} ");

    }
    Console.WriteLine("With higest score:" + maxValue);

}
else

    Console.WriteLine($" The higest scored employee is {maxScoredEmployee.Name} {maxScoredEmployee.Surname} Age: {maxScoredEmployee.Age} with score: {maxScoredEmployee.Result}");
    Console.WriteLine($" The higest scored employee is {maxScoredEmployee.Name} {maxScoredEmployee.Surname} Age: {maxScoredEmployee.Age} with score: {maxScoredEmployee.Result}");

