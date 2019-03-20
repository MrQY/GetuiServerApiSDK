namespace GetuiServerApiSDK.payload
{
    public class MultiMedia
    {
        public enum MediaType
        {
            pic = 1,
            audio = 2,
            video = 3
        }

        public string rid { get; set; }

        public string url { get; set; }

        public int onlywifi { get; private set; }

        public MediaType type { get; set; }

        public void setIsOnlyWifi(bool value)
        {
            onlywifi = value ? 1 : 0;
        }
    }
}