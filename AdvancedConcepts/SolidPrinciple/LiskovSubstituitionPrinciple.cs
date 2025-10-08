namespace AdvancedConcepts.SolidPrinciple;
public abstract class EmployeeLSP
{
    public string Name { get; set; }
    public int Id { get; set; }
    public abstract double GetMinimumSalary();
}

public class PermanentEmployeeLSP : EmployeeLSP
{
    public override double GetMinimumSalary()
    {
        return 50000;
    }
}

public class ContractEmployeeLSP : EmployeeLSP
{
    public override double GetMinimumSalary()
    {
        return 30000;
    }
}

// LSP is followed because both PermanentEmployee and ContractEmployee can be used interchangeably
public class EmployeeManager
{
    public void PrintMinimumSalary(EmployeeLSP employee)
    {
        Console.WriteLine(employee.GetMinimumSalary());
    }
}
