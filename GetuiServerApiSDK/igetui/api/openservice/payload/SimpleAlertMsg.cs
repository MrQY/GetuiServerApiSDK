namespace com.igetui.api.openservice.payload
{
  public class SimpleAlertMsg : AlertMsg
  {
    private string alertMsg;

    public SimpleAlertMsg(string alertMsg)
    {
      this.alertMsg = alertMsg;
    }

    public SimpleAlertMsg()
    {
    }

    public object getAlertMsg()
    {
      return (object) this.alertMsg;
    }
  }
}
