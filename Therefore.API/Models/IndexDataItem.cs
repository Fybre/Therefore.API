namespace Therefore.API.Models
{
    public class IndexDataItem
    {
        public DateIndexData DateIndexData { get; set; }
        public IntIndexData IntIndexData { get; set; }
        public LogicalIndexData LogicalIndexData { get; set; }
        public MoneyIndexData MoneyIndexData { get; set; }
        public MultipleKeywordData MultipleKeywordData { get; set; }
        public SingleKeywordData SingleKeywordData { get; set; }
        public StringIndexData StringIndexData { get; set; }
        public TableIndexData TableIndexData { get; set; }
        public AccessMask AccessMask { get; set; }
        public DateTimeIndexData DateTimeIndexData { get; set; }
        public RoleAccessMask RoleAccessMask { get; set; }
    }


}
