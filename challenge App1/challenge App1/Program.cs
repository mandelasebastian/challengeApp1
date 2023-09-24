using challengeApp1;

Employee employee1 = new Employee("Sebastian", "Mandela", 41);
Employee employee2 = new Employee("Aldona", "Mandela", 36);
Employee employee3 = new Employee("Iga", "Mandela", 18);

employee1.AddScore(5);
employee1.AddScore(6);
employee1.AddScore(3);
employee1.AddScore(4);
employee1.AddScore(7);

employee2.AddScore(6);
employee2.AddScore(6);
employee2.AddScore(4);
employee2.AddScore(8);
employee2.AddScore(9);

employee3.AddScore(2);
employee3.AddScore(9);
employee3.AddScore(3);
employee3.AddScore(6);
employee3.AddScore(3);

List<Employee> employees = new List<Employee>()
    {
    employee1, employee2, employee3,
    };

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employeeWithMaxResult.Result;
    }
}

var name = employeeWithMaxResult.Name;
var surname = employeeWithMaxResult.Surname;
var age = employeeWithMaxResult.Age;
var result = employeeWithMaxResult.Result;

Console.WriteLine
    ("Pracownik z najwyższą liczbą punktów:" + name + " " + surname + "," + age + "lat" +":" + result + "pkt.");
 