namespace Therefore.API.Models
{
    public class ResultRow
    {
        public AccessMask AccessMask { get; set; }
        public long DocNo { get; set; }
        public List<string> IndexValues { get; set; }
        public long Size { get; set; }
        public long VersionNo { get; set; }
        public int Status { get; set; }
        public RoleAccessMask RoleAccessMask { get; set; }
    }


}
