namespace Therefore.API.Models
{
    public class DocTitleConfig
    {
        public List<long> FieldNos { get; set; }
        public bool HideCtgryName { get; set; }
        public long MaxLength { get; set; }
        public bool ShowFieldName { get; set; }
        public int TitleType { get; set; }
    }


}
