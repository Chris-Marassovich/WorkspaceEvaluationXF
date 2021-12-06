using System.Collections.Generic;
using WorkspaceEvaluationXF.Models;

namespace WorkspaceEvaluationXF.Services
{
    public class WorkspaceRepository
    {
        private List<dsWorkspace> Workspaces { get; set; }

        public WorkspaceRepository()
        {
            Workspaces = new List<dsWorkspace>()
            {
                new dsWorkspace(){ Title = "Workspace 1", Pages = new List<dsWorkspacePage>(){ new dsWorkspacePage() { Title = "Page 1"} }},
                new dsWorkspace(){ Title = "Workspace 2", Pages = new List<dsWorkspacePage>(){ new dsWorkspacePage() { Title = "Page 1"},
                                                                                               new dsWorkspacePage() { Title = "Page 2"}} },
                new dsWorkspace(){ Title = "Workspace 3", Pages = new List<dsWorkspacePage>(){ new dsWorkspacePage() { Title = "Page 1"} }},
                new dsWorkspace(){ Title = "Workspace 4", Pages = new List<dsWorkspacePage>(){ new dsWorkspacePage() { Title = "Page 1"} }},
                new dsWorkspace(){ Title = "Workspace 5", Pages = new List<dsWorkspacePage>(){ new dsWorkspacePage() { Title = "Page 1"} }},
                new dsWorkspace(){ Title = "Workspace 6", Pages = new List<dsWorkspacePage>(){ new dsWorkspacePage() { Title = "Page 1"} }},
                new dsWorkspace(){ Title = "Workspace 7", Pages = new List<dsWorkspacePage>(){ new dsWorkspacePage() { Title = "Page 1"},
                                                                                               new dsWorkspacePage() { Title = "Page 2"},
                                                                                                new dsWorkspacePage() { Title = "Page Threeeeee"},
                                                                                                new dsWorkspacePage() { Title = "Page 4"},
                                                                                                new dsWorkspacePage() { Title = "Page 5"},
                                                                                                new dsWorkspacePage() { Title = "Page 6"},
                                                                                                new dsWorkspacePage() { Title = "Page 7"}} },
            };
        }

        public List<dsWorkspace> GetNeatAmount()
        {
            return Workspaces.GetRange(0, 3);
        }

        public List<dsWorkspace> GetAll()
        {
            return Workspaces;
        }
    }
}
