namespace Therefore.API.Models
{
    public class Transition
    {
        public string ActionText { get; set; }
        public bool IsDefault { get; set; }
        public bool IsHidden { get; set; }
        public bool IsValid { get; set; }
        public bool RequestInfo { get; set; }
        public long SeqPos { get; set; }
        public long TaskFromNo { get; set; }
        public long TaskToNo { get; set; }
        public string Description { get; set; }
    }


}
