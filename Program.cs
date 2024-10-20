using System;
using System.Text;

class Employee
{

    public string Name;
    public double Salary;

   
    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Ім'я: {Name}, Зарплата: {Salary}");
    }

    public virtual double CalculateSalary()
    {
        return Salary;
    }
}

class Official : Employee
{
    
    public int Experience { get; set; }
    public double Bonus { get; set; }

    
    public Official(string name, double salary, int experience, double bonus)
        : base(name, salary)
    {
        Experience = experience;
        Bonus = bonus;
    }

    
    public void DisplayAllInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Стаж роботи: {Experience}, Надбавка за стаж: {Bonus}");
    }

    
    public double CalculateTotalIncome(int experience, double bonus)
    {
        return Salary + bonus;
    }

    
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Стаж роботи: {Experience}, Надбавка за стаж: {Bonus}");
    }

    
    public override double CalculateSalary()
    {
        return Salary + Bonus;
    }
}

class Worker : Employee
{
    
    public Worker(string name, double salary) : base(name, salary) { }

    
    public void DisplayPositionAndSalary(string position, double salary)
    {
        Console.WriteLine($"Посада: {position}, Зарплата: {salary}");
    }

    
    public double CalculateAverageSalary()
    {
        double[] salaries = { 1000, 1050, 1100, 1150, 1200, 1250 };
        double total = 0;
        foreach (double s in salaries)
        {
            total += s;
        }
        return total / salaries.Length;
    }

    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Ім'я: {Name}, Зарплата: {Salary}");
    }

    
    public override double CalculateSalary()
    {
        return Salary;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Official official = new Official("Олена", 2000, 5, 300);


        official.DisplayAllInfo();
        double totalIncome = official.CalculateTotalIncome(official.Experience, official.Bonus);
        Console.WriteLine($"Сукупний дохід: {totalIncome}");


        Worker worker = new Worker("Іван", 1500);


        worker.DisplayPositionAndSalary("слюсар", worker.Salary);
        double avgSalary = worker.CalculateAverageSalary();
        Console.WriteLine($"Середня зарплата за 6 місяців: {avgSalary}");


        official.DisplayInfo();
        worker.DisplayInfo();
    }
}

