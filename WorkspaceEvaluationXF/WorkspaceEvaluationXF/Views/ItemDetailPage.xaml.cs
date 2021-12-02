using System.ComponentModel;
using WorkspaceEvaluationXF.ViewModels;
using Xamarin.Forms;

namespace WorkspaceEvaluationXF.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}