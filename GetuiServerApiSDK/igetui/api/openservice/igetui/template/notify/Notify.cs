using com.gexin.rp.sdk.dto;
using System;

namespace com.igetui.api.openservice.igetui.template.notify
{
  public class Notify
  {
    private string title;
    private string content;
    private string payload;
    private string url;
    private string intent;
    private NotifyInfo.Types.Type type;
    private int? notifyId;

    public int? getNotifyId()
    {
      return this.notifyId;
    }

    public void setNotifyId(int? notifyId)
    {
      int? nullable = notifyId;
      int num = 0;
      if ((nullable.GetValueOrDefault() < num ? (nullable.HasValue ? 1 : 0) : 0) != 0)
        throw new Exception("notifyId need greater than 0");
      this.notifyId = notifyId;
    }

    public string Title
    {
      get
      {
        return this.title;
      }
      set
      {
        this.title = value;
      }
    }

    public string Content
    {
      get
      {
        return this.content;
      }
      set
      {
        this.content = value;
      }
    }

    public string Payload
    {
      get
      {
        return this.payload;
      }
      set
      {
        this.payload = value;
      }
    }

    public string Url
    {
      get
      {
        return this.url;
      }
      set
      {
        this.url = value;
      }
    }

    public string Intent
    {
      get
      {
        return this.intent;
      }
      set
      {
        this.intent = value;
      }
    }

    public NotifyInfo.Types.Type Type
    {
      get
      {
        return this.type;
      }
      set
      {
        this.type = value;
      }
    }
  }
}
