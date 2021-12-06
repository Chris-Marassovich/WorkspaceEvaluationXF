using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkspaceEvaluationXF.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkspaceEvaluationXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XCTTabViewPage : ContentPage
    {
        AppShellViewModel ViewModel { get; set; }

        public XCTTabViewPage()
        {
            InitializeComponent();
            ViewModel = DependencyService.Resolve<AppShellViewModel>();
            BindingContext = ViewModel;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            ViewModel.BuildWorkspaceTabView(WorkspaceTabView);
        }
    }
}