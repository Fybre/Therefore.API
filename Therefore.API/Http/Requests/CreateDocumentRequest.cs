using Therefore.API.Models;

namespace Therefore.API.Http.Requests
{
    public class CreateDocumentRequest
    {
        public long CategoryNo { get; set; }
        public string CheckInComments { get; set; }
        public List<IndexDataItem> IndexDataItems { get; set; }
        public List<Models.Stream> Streams { get; set; }
        public bool DoFillDependentFields { get; set; }
        public int WithAutoAppendMode { get; set; }
        public ConversionOptions ConversionOptions { get; set; }
        public DateTime LastChangeTime { get; set; }
        public bool DontResetCategoryDefaults { get; set; }
        public List<FileUploadSession> FileUploadSessions { get; set; }
        public int AutoAppendIdxMerge { get; set; }
        public string LastChangeTimeISO8601 { get; set; }
    }


}
