namespace com.igetui.api.openservice.igetui
{
  public class Message : IPacket
  {
    private bool isOffline;
    private long offlineExpireTime;
    private int pushNetWorkType;
    private ITemplate data;

    public bool IsOffline
    {
      get
      {
        return this.isOffline;
      }
      set
      {
        this.isOffline = value;
      }
    }

    public long OfflineExpireTime
    {
      get
      {
        return this.offlineExpireTime;
      }
      set
      {
        this.offlineExpireTime = value;
      }
    }

    public int PushNetWorkType
    {
      get
      {
        return this.pushNetWorkType;
      }
      set
      {
        this.pushNetWorkType = value;
      }
    }

    public ITemplate Data
    {
      get
      {
        return this.data;
      }
      set
      {
        this.data = value;
      }
    }
  }
}
