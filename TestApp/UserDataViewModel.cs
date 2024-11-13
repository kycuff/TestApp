using CommunityToolkit.Mvvm.ComponentModel;

namespace TestApp;
public partial class UserDataViewModel : ObservableObject
{
    public UsersDataModel UsersData { get; set; }
    public UserDataViewModel()
    {
        UsersData = new UsersDataModel
        {
            InstalmentPlans = new InstalmentPlans
            {
                InstalmentPlan = new[]
                {
                    new InstalmentPlan { FinancialYear = "2023" }
                }
            }
        };
    }
}
