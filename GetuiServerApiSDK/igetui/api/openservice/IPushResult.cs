using System.Collections.Generic;

namespace com.igetui.api.openservice
{
  public interface IPushResult
  {
    EPushResult getResultCode();

    string getTaskId();

    string getMessageId();

    Dictionary<string, object> getResponse();
  }
}
