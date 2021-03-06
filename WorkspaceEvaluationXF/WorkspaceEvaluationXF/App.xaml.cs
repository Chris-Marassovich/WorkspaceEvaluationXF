using System;
using WorkspaceEvaluationXF.Services;
using WorkspaceEvaluationXF.ViewModels;
using WorkspaceEvaluationXF.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkspaceEvaluationXF
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.RegisterSingleton(new AppShellViewModel());
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
