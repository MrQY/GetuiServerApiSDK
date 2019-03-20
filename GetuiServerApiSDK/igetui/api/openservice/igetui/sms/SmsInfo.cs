using System.Collections.Generic;

namespace com.igetui.api.openservice.igetui.sms
{
  public class SmsInfo
  {
    private string smsTemplateId;
    private Dictionary<string, string> smsContent;
    private long offlineSendtime;
    private string url;
    private bool isApplink;
    private string payload;

    public string SmsTemplateId
    {
      get
      {
        return this.smsTemplateId;
      }
      set
      {
        this.smsTemplateId = value;
      }
    }

    public Dictionary<string, string> SmsContent
    {
      get
      {
        return this.smsContent;
      }
      set
      {
        this.smsContent = value;
      }
    }

    public long OfflineSendtime
    {
      get
      {
        return this.offlineSendtime;
      }
      set
      {
        this.offlineSendtime = value;
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

    public bool IsApplink
    {
      get
      {
        return this.isApplink;
      }
      set
      {
        this.isApplink = value;
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
  }
}
