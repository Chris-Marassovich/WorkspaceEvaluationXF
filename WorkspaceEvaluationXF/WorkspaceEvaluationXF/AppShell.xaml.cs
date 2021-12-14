using System;
using System.Collections.Generic;
using WorkspaceEvaluationXF.ViewModels;
using WorkspaceEvaluationXF.Views;
using Xamarin.Forms;

namespace WorkspaceEvaluationXF
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        AppShellViewModel ViewModel { get; set; }

        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));

            ViewModel = DependencyService.Resolve<AppShellViewModel>();
            BindingContext = ViewModel;
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        private void Rebuild_NeatClicked(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = false;

            ViewModel.BuildWorkspaceMenu(WorkspaceFlyoutItem, IsNeat: true);
            
        }

        private void Rebuild_AllClicked(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = false;

            ViewModel.BuildWorkspaceMenu(WorkspaceFlyoutItem, IsNeat: false);
        }
    }
}
