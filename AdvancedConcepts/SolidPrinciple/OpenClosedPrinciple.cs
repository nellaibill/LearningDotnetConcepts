namespace AdvancedConcepts.SolidPrinciple;
public class EmployeeOCPViolation
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    // This method violates OCP because adding new employee types requires modifying this method
    public double CalculateBonus(string employeeType)
    {
        if (employeeType == "Permanent")
        {
            return Salary * 0.1;
        }
        else if (employeeType == "Contract")
        {
            return Salary * 0.05;
        }
        return 0;
    }
}

// Refactored to follow OCP
public abstract class EmployeeOCP
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }
    public abstract double CalculateBonus();

}

public class PermanentEmployeeOCP : EmployeeOCP
{
    public override double CalculateBonus()
    {
        return Salary * 0.1;
    }
}

public class ContractEmployeeOCP : EmployeeOCP
{
    public override double CalculateBonus()
    {
        return Salary * 0.05;
    }
}
