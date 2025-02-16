namespace Therefore.API.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);


    public class Column
    {
        public long BelongsTo { get; set; }
        public long BelongsToTable { get; set; }
        public string Caption { get; set; }
        public bool CaseSensitive { get; set; }
        public string ColName { get; set; }
        public int CounterMode { get; set; }
        public string DefaultVal { get; set; }
        public int DependencyMode { get; set; }
        public long DisplayOrderPos { get; set; }
        public bool DontLoadValues { get; set; }
        public long FieldNo { get; set; }
        public int FieldType { get; set; }
        public string ForeignCol { get; set; }
        public string Guid { get; set; }
        public long Height { get; set; }
        public string IndexDataFieldName { get; set; }
        public long IndexType { get; set; }
        public bool IsForeignDatatype { get; set; }
        public bool IsMultipleKeyword { get; set; }
        public bool IsSingleKeyword { get; set; }
        public bool KeepRedundant { get; set; }
        public long Length { get; set; }
        public bool Mandatory { get; set; }
        public long PosX { get; set; }
        public long PosY { get; set; }
        public string RegularExpr { get; set; }
        public long TabOrderPos { get; set; }
        public int TypeGroup { get; set; }
        public string TypeIndexColumn { get; set; }
        public string TypeMultiInner { get; set; }
        public string TypeMultiJoin { get; set; }
        public string TypeMultiOuter { get; set; }
        public long TypeNo { get; set; }
        public string TypeTableName { get; set; }
        public bool Visible { get; set; }
        public long Width { get; set; }
        public string WorkflowField { get; set; }
        public bool SelectFromDropDownBox { get; set; }
        public DisplayProperties DisplayProperties { get; set; }
        public long ImageDocNo { get; set; }
        public bool IsImageFieldType { get; set; }
        public bool IsTabControlFieldType { get; set; }
        public long ParentFieldNo { get; set; }
        public long ShowInTabNo { get; set; }
        public List<Tab> Tabs { get; set; }
        public AccessMask AccessMask { get; set; }
        public bool IsAutoAppendField { get; set; }
        public bool IsDateTimeFieldType { get; set; }
        public long Scale { get; set; }
        public string RegExSample { get; set; }
        public string FieldID { get; set; }
        public string Condition { get; set; }
        public ConditionalFormatting ConditionalFormatting { get; set; }
        public string Formula { get; set; }
        public bool IsCalculationTrigger { get; set; }
        public bool IsFormattingTrigger { get; set; }
        public RoleAccessMask RoleAccessMask { get; set; }
        public bool SortDescending { get; set; }
        public List<Filter> Filter { get; set; }
        public int ConditionMode { get; set; }
        public bool IsDependencyTrigger { get; set; }
    }


}
