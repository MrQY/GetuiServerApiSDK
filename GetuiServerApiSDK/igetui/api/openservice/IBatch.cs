using com.igetui.api.openservice.igetui;

namespace com.igetui.api.openservice
{
  public interface IBatch
  {
    void setApiUrl(string apiUrl);

    string add(SingleMessage message, Target target);

    string submit();

    string retry();
  }
}
