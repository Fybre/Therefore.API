using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therefore.API.Models
{

    public class WorkflowProcess
    {
        public bool Activated { get; set; }
        public bool AllowManualStart { get; set; }
        public long CaseDefinitionNo { get; set; }
        public long CategoryNo { get; set; }
        public long DaysToDeleteInstances { get; set; }
        public string DelegateMailText { get; set; }
        public string Description { get; set; }
        public long Duration { get; set; }
        public bool Enabled { get; set; }
        public long FolderNo { get; set; }
        public string Guid { get; set; }
        public DateTime LastModified { get; set; }
        public string Name { get; set; }
        public string NotificationMailText { get; set; }
        public string NotifyOnError { get; set; }
        public string OverdueMailText { get; set; }
        public long ProcessNo { get; set; }
        public long VersionNo { get; set; }
        public List<Task> Tasks { get; set; }
        public string LastModifiedISO8601 { get; set; }
    }


}
