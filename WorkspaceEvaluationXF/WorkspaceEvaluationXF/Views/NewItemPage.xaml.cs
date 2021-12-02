using System;
using System.Collections.Generic;
using System.ComponentModel;
using WorkspaceEvaluationXF.Models;
using WorkspaceEvaluationXF.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkspaceEvaluationXF.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}