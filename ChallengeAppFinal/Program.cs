using ChallengeAppFinal;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}"); // N2 - dwa miejsca po przecinku. Interpolacja stringów.
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");



int[] grades = new int[5];
