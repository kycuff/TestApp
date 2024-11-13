namespace TestApp;

public class UsersDataModel
{
    public InstalmentPlans InstalmentPlans { get; set; } = new();
}

public class InstalmentPlans
{
    public InstalmentPlan[] InstalmentPlan { get; set; } = [];
}

public class InstalmentPlan
{
    public string FinancialYear { get; set; } = string.Empty;
}