using ChallengeApp9;
 

    var employee = new Employee("Aleksy", "Dowejko");
    employee.AddGrade(8);
    employee.AddGrade(5);
    employee.AddGrade(6);
    var stat = employee.GetStatistics();
    Console.WriteLine($"Average: {stat.Average:N2}");
    Console.WriteLine($"Min: {stat.Min}");
    Console.WriteLine($"Max: {stat.Max}");

    SetSth(out stat);


    void SetSth(out Statistics stat)
    {
        stat = new Statistics();
    }

   


