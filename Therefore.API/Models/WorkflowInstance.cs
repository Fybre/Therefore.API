namespace Therefore.API.Models
{
    public class WorkflowInstance
    {
        public bool AskForPwd { get; set; }
        public string AssignedTo { get; set; }
        public long ChecklistItemCount { get; set; }
        public bool Claimed { get; set; }
        public string CurrTaskName { get; set; }
        public long CurrTaskNo { get; set; }
        public long CurrTaskType { get; set; }
        public bool DelegationDisabled { get; set; }
        public long HistoryEntryCount { get; set; }
        public long InitiatorNo { get; set; }
        public long InstanceNo { get; set; }
        public bool IsAssignedToUser { get; set; }
        public bool IsChangeCtgry { get; set; }
        public bool IsProcessOwner { get; set; }
        public long LinkedDocCount { get; set; }
        public long NextTaskCount { get; set; }
        public DateTime ProcessDueDate { get; set; }
        public string ProcessName { get; set; }
        public long ProcessNo { get; set; }
        public DateTime ProcessStartDate { get; set; }
        public DateTime TaskDueDate { get; set; }
        public DateTime TaskStartDate { get; set; }
        public string Text { get; set; }
        public long TokenNo { get; set; }
        public long TransitionCount { get; set; }
        public bool UseChecklist { get; set; }
        public long VersionNo { get; set; }
        public string ErrorInfo { get; set; }
        public string ErrorString { get; set; }
        public DateTime ErrorTimestamp { get; set; }
        public List<long> AssignedToUsers { get; set; }
        public List<long> OriginallyAssignedToUsers { get; set; }
        public CurrentTask CurrentTask { get; set; }
        public bool IsSmartCaptureVerification { get; set; }
        public string CurrTaskId { get; set; }
        public string CurrTaskGUID { get; set; }
        public string ErrorTimestampISO8601 { get; set; }
        public string ProcessDueDateISO8601 { get; set; }
        public string ProcessStartDateISO8601 { get; set; }
        public string TaskDueDateISO8601 { get; set; }
        public string TaskStartDateISO8601 { get; set; }
    }


}
