namespace Therefore.API.Models
{
    public class Stream
    {
        public List<int> FileData { get; set; }
        public string FileName { get; set; }
        public long StreamNo { get; set; }
        public string FileDataBase64JSON { get; set; }
        public int NewStreamInsertMode { get; set; }
    }


}
