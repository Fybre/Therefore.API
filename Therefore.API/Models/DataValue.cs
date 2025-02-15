namespace Therefore.API.Models
{
    public class DataValue
    {
        public List<DataRowItem> DataRowItems { get; set; }
        public long RowNo { get; set; }
        public bool AccessIsEditableRow { get; set; }
    }


}
