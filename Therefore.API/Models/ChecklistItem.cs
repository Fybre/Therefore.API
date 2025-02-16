namespace Therefore.API.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ChecklistItem
    {
        public bool Checked { get; set; }
        public long SeqPos { get; set; }
        public long TaskNo { get; set; }
        public string Text { get; set; }
    }


}
