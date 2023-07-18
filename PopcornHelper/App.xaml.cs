
namespace PopcornHelper
{
    public partial class App : Application
    {
        private static Realms.Sync.App realmApp;
        public static Realms.Sync.App RealmApp
        {
            get => realmApp;
            set => realmApp = value;
        }

        public App()
        {
            InitializeComponent();

            RealmApp = Realms.Sync.App.Create(AppConfig.RealmAppId);

            MainPage = new AppShell();
        }

    }
}