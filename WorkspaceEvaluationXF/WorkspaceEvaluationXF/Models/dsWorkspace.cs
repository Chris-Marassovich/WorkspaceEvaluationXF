using System;
using System.Collections.Generic;
using System.Text;

namespace WorkspaceEvaluationXF.Models
{
    public class dsWorkspace
    {
        public string Title { get; set; }
        public string Route { get; set; }
        public List<dsWorkspacePage> Pages { get; set; } = new List<dsWorkspacePage>();
    }
}
