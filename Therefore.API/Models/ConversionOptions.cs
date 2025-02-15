namespace Therefore.API.Models
{
    public class ConversionOptions
    {
        public int AnnotationMode { get; set; }
        public string CertificateName { get; set; }
        public int ConvertTo { get; set; }
        public int SignatureMode { get; set; }
        public string TimeStampPwd { get; set; }
        public string TimeStampServer { get; set; }
        public string TimeStampUser { get; set; }
        public string MultipageStreamName { get; set; }
    }


}
