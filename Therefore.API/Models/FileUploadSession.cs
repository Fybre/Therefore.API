namespace Therefore.API.Models
{
    public class FileUploadSession
    {
        public string FileName { get; set; }
        public long StreamNo { get; set; }
        public string UploadSessionId { get; set; }
        public int NewStreamInsertMode { get; set; }
    }


}
