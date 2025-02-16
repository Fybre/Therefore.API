namespace Therefore.API.Models
{
    public class NextTask
    {
        public bool AllowMultiSelection { get; set; }
        public bool AskForPwd { get; set; }
        public long AssignFromFieldNo { get; set; }
        public long ChoiceCount { get; set; }
        public List<Choice> Choices { get; set; }
        public long Duration { get; set; }
        public string Guid { get; set; }
        public bool IsDelegationDisabled { get; set; }
        public string Name { get; set; }
        public long ProcessNo { get; set; }
        public long SeqPos { get; set; }
        public int Type { get; set; }
        public bool UseChecklist { get; set; }
        public bool UserChoice { get; set; }
        public long VersionNo { get; set; }
        public long TaskNo { get; set; }
        public string ActionTypeId { get; set; }
        public string TaskGUID { get; set; }
    }


}
