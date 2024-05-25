namespace MediaAppService.DataContract
{
    public class VideoDataContract
    {
        public int VersionId { get; set; }

        public bool isLastestVersion { get; set; }

        public required string VideoName { get; set; }

        public long VideoSize { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
