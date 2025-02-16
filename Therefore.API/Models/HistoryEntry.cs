namespace Therefore.API.Models
{
    public class HistoryEntry
    {
        public DateTime ActionDate { get; set; }
        public long SeqPos { get; set; }
        public string TaskName { get; set; }
        public long TaskNo { get; set; }
        public long TaskToNo { get; set; }
        public string Text { get; set; }
        public int Type { get; set; }
        public string UserName { get; set; }
        public long UserNo { get; set; }
        public long CustomEntryTypeNumber { get; set; }
        public string ActionDateISO8601 { get; set; }
    }


}
