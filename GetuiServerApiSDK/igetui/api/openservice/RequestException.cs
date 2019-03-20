using System;

namespace com.igetui.api.openservice
{
  public class RequestException : ApplicationException
  {
    private string requestId;

    public RequestException(string requestId, Exception e)
      : this(requestId, (string) null, e)
    {
    }

    public RequestException(string requestId, string message)
      : this(requestId, message, (Exception) null)
    {
    }

    public RequestException(string requestId, string message, Exception e)
      : base(message, e)
    {
      this.requestId = requestId;
    }

    public string RequestId
    {
      get
      {
        return this.requestId;
      }
    }
  }
}
