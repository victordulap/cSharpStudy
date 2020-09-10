using System;


class Employee
{
    public string FirstName;
    public string LastName;
    public int Salary;

    public Employee(string _firstName, string _lastName, int _salary)
    {
        FirstName = _firstName;
        LastName = _lastName;
        Salary = _salary;
    }

    //main
    private static void Main()
    {
        Employee employee = new Employee("John", "Carmack", 15000);
        employee.SaveData();
    }

    public void SaveData()
    {
        DataStorage.Store(this);
    }
}

class DataStorage
{
    public static void Store(Employee employee)
    {
        Console.WriteLine("Employee {0} {1} has a monthly salary of {2}$.", employee.FirstName, employee.LastName, employee.Salary);
    }
}
