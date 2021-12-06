using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkspaceEvaluationXF.Models;
using WorkspaceEvaluationXF.Services;
using WorkspaceEvaluationXF.Views;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace WorkspaceEvaluationXF.ViewModels
{
    public class AppShellViewModel : BaseViewModel
    {
        public WorkspaceRepository WorkspaceRepository { get; set; }
        
        public AppShellViewModel()
        {
            WorkspaceRepository = new WorkspaceRepository();
        }

        public void BuildWorkspaceMenu(FlyoutItem flyoutItem, bool IsNeat)
        {
            IsBusy = true;
            flyoutItem.Items.Clear();

            List<dsWorkspace> workspaces;
            if (IsNeat == true)
            {
                workspaces = WorkspaceRepository.GetNeatAmount();
            }
            else
            {
                workspaces = WorkspaceRepository.GetAll();
            }

            foreach (var workspace in workspaces)
            {
                if (workspace.Pages.Count() > 1)
                {
                    var tab = new Tab()
                    {
                        Title = workspace.Title
                    };
                    foreach (var page in workspace.Pages)
                    {
                        tab.Items.Add(new ShellContent()
                        {
                            Title = page.Title,
                            Content = new BlankPage() { Title = page.Title }
                        });
                    }
                    flyoutItem.Items.Add(tab);
                }
                else
                {
                    flyoutItem.Items.Add(new ShellContent()
                    {
                        Title = workspace.Title,
                        Content = new BlankPage() { Title = workspace.Pages.First().Title }
                    });
                }
            }


            IsBusy = false;
        }

        public void BuildWorkspaceTabView(TabView tabView)
        {
            ///Nesting works nicely at design time.
            ///I have looked into doing it from code by adding to the TabView collections and it does not work well.
            ///I cannot see either how to do nesting if using ItemSource.
            ///I have observed on github that there is a lot of open(year or more) issues around this topic.
           IsBusy = true;
            tabView.TabItems.Clear();

            tabView.TabItems.Add(new TabViewItem()
            {
                Text = "Workspace 1",
            });

            tabView.TabItems.Add(new TabViewItem()
            {
                Text = "Workspace 3",
            });
            IsBusy = false;
        }

        public void BuildWorkspaceXFTabPage(TabbedPage tabbedPage)
        {
            IsBusy = true;

            tabbedPage.Children.Clear();

            List<dsWorkspace> workspaces;
            //workspaces = WorkspaceRepository.GetNeatAmount();
            workspaces = WorkspaceRepository.GetAll();

            foreach (var workspace in workspaces)
            {
                if (workspace.Pages.Count() > 1)
                {
                    var newtabbedpage = new TabbedPage();
                    newtabbedpage.Title = workspace.Title;
                    foreach (var page in workspace.Pages)
                    {
                        newtabbedpage.Children.Add(new BlankPage() { Title = page.Title });
                    }

                    tabbedPage.Children.Add(newtabbedpage);
                }
                else
                {
                    tabbedPage.Children.Add(new BlankPage() { Title = workspace.Title });
                }
            }
            //tabbedPage.Children.Add(new XFTabPage1());
            //tabbedPage.Children.Add(new XFTab2TabbedPage());

            IsBusy = false;
        }
    }
}
