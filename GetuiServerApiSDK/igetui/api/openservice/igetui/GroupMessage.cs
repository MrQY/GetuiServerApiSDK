namespace com.igetui.api.openservice.igetui
{
  public class GroupMessage
  {
    private string groupId;
    private string requestId;
    private ITemplate data;

    public string GroupId
    {
      get
      {
        return this.groupId;
      }
      set
      {
        this.groupId = value;
      }
    }

    public string RequestId
    {
      get
      {
        return this.requestId;
      }
      set
      {
        this.requestId = value;
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
