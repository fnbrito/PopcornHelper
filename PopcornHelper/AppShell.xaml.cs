using PopcornHelper.Views;

namespace PopcornHelper
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(Home), typeof(Home));
            Routing.RegisterRoute(nameof(BatchesDashboard), typeof(BatchesDashboard));
            Routing.RegisterRoute(nameof(OrdersDashboard), typeof(OrdersDashboard));
        }
    }
}