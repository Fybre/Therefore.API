namespace Therefore.API.Models
{
    public class QueryResult
    {
        public long CaseDefinitionNo { get; set; }
        public long CategoryNo { get; set; }
        public long ProcessNo { get; set; }
        public List<ResultRow> ResultRows { get; set; }
        public List<Column> Columns { get; set; }
        public List<DocTitleConfig> DocTitleConfig { get; set; }
    }


}
