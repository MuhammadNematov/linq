// Task 1
List<Employee> employees = new List<Employee>
{
    new Employee
    {
        Id = 1,
        FirstName = "Muhammad",
        LastName = "Nematov",
        Age = 25,
        Salary = 6000,
        Experience = 5
    },

    new Employee
    {
        Id = 2,
        FirstName = "Ali",
        LastName = "Karimov",
        Age = 30,
        Salary = 7000,
        Experience = 8
    },

    new Employee
    {
        Id = 3,
        FirstName = "Alexander",
        LastName = "Smith",
        Age = 28,
        Salary = 4500,
        Experience = 6
    },

    new Employee
    {
        Id = 4,
        FirstName = "John",
        LastName = "Brown",
        Age = 35,
        Salary = 9000,
        Experience = 12
    },

    new Employee
    {
        Id = 5,
        FirstName = "Islom",
        LastName = "Rahmonov",
        Age = 22,
        Salary = 3000,
        Experience = 3
    },

    new Employee
    {
        Id = 6,
        FirstName = "Abdulloh",
        LastName = "Saidov",
        Age = 27,
        Salary = 5500,
        Experience = 7
    }
};

// Task 1
var salaries = employees
    .Select(employee => employee.Salary);

foreach (var salary in salaries)
{
    Console.WriteLine(salary);
}


// Task 2
var result = employees
    .Where(employee => employee.FirstName.Length > 6);

foreach (var employee in result)
{
    Console.WriteLine(employee.FirstName);
}

// Task 3
var firstEmployee = employees[0];

var result = employees
    .Where(employee => employee.Age > firstEmployee.Age)
    .Select(employee => employee.FirstName + " " + employee.LastName);

foreach (var fullName in result)
{
    Console.WriteLine(fullName);
}

//  Task 4
var result = employees
    .Where(employee => employee.Experience > employee.Age / 2);

foreach (var employee in result)
{
    Console.WriteLine(employee.FirstName + " " + employee.LastName);
}

// Task 5
var result = employees
    .Where(employee => employee.Salary > 5000)
    .OrderByDescending(employee => employee.Experience)
    .Take(3);

foreach (var employee in result)
{
    Console.WriteLine(employee.FirstName + " " + employee.LastName);
}



// HomeTask
List<Student> students = new List<Student>
{
    new Student
    {
        Id = 1,
        FirstName = "Ali",
        LastName = "Karimov",
        Age = 20,
        Gender = "Male",
        Status = "Active",
        DateOfStart = new DateTime(2022, 9, 1),
        DateOfFinish = new DateTime(2026, 6, 30)
    },

    new Student
    {
        Id = 2,
        FirstName = "Amina",
        LastName = "Saidova",
        Age = 22,
        Gender = "Female",
        Status = "Active",
        DateOfStart = new DateTime(2021, 9, 1),
        DateOfFinish = new DateTime(2025, 6, 30)
    },

    new Student
    {
        Id = 3,
        FirstName = "Islom",
        LastName = "Rahmonov",
        Age = 19,
        Gender = "Male",
        Status = "InActive",
        DateOfStart = new DateTime(2023, 9, 1),
        DateOfFinish = new DateTime(2027, 6, 30)
    },

    new Student
    {
        Id = 4,
        FirstName = "Ibrohim",
        LastName = "Davlatov",
        Age = 24,
        Gender = "Male",
        Status = "Active",
        DateOfStart = new DateTime(2020, 9, 1),
        DateOfFinish = new DateTime(2024, 6, 30)
    },

    new Student
    {
        Id = 5,
        FirstName = "Madina",
        LastName = "Azimova",
        Age = 21,
        Gender = "Female",
        Status = "InActive",
        DateOfStart = new DateTime(2022, 9, 1),
        DateOfFinish = new DateTime(2026, 6, 30)
    },

    new Student
    {
        Id = 6,
        FirstName = "Abdulloh",
        LastName = "Saidov",
        Age = 25,
        Gender = "Male",
        Status = "Active",
        DateOfStart = new DateTime(2019, 9, 1),
        DateOfFinish = new DateTime(2023, 6, 30)
    },

    new Student
    {
        Id = 7,
        FirstName = "Aisha",
        LastName = "Nazarova",
        Age = 18,
        Gender = "Female",
        Status = "Active",
        DateOfStart = new DateTime(2024, 9, 1),
        DateOfFinish = new DateTime(2028, 6, 30)
    }
};


// Task 1
var result = students
    .Where(student => student.Gender == "Male");

foreach (var student in result)
{
    Console.WriteLine(student.FirstName + " " + student.LastName);
}

// Task 2
var result = students
    .Where(student => student.Status == "InActive");

foreach (var student in result)
{
    Console.WriteLine(student.FirstName + " " + student.LastName);
}

// Task 3
var result = students
    .Where(student => student.DateOfStart.Year > 2000);

foreach (var student in result)
{
    Console.WriteLine(student.FirstName + " " + student.LastName);
}

// Task 4
var result = students
    .Where(student =>
        student.Age > 20 &&
        student.Status == "Active");

foreach (var student in result)
{
    Console.WriteLine(student.FirstName + " " + student.LastName);
}

// Task 7
var result = students
    .Where(student =>
        student.FirstName.StartsWith("A") ||
        student.FirstName.StartsWith("I"));

foreach (var student in result)
{
    Console.WriteLine(student.FirstName + " " + student.LastName);
}

// Task 8
var result = students
    .Where(student =>
        student.FirstName[0] == student.LastName[0]);

foreach (var student in result)
{
    Console.WriteLine(student.FirstName + " " + student.LastName);
}

// Task 10
var result = students
    .Where(student =>
        student.Gender != "Female" &&
        student.Status == "Active" &&
        (student.DateOfFinish - student.DateOfStart).TotalDays > 2 * 365 &&
        student.Age < 16);

foreach(var student in result)
{
    Console.WriteLine(student.FirstName + " " + student.LastName);
}        
