using GetuiServerApiSDK.payload;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.payload
{
  public class APNPayload : Payload
  {
    private List<MultiMedia> multiMedias = new List<MultiMedia>();
    private Dictionary<string, object> customMsg = new Dictionary<string, object>();
    private int badge = -1;
    private string sound = "default";
    public const string APN_SOUND_SILENCE = "com.gexin.ios.silence";
    public const int PAYLOAD_MAX_BYTES = 2048;
    private int voicePlayType;
    private string voicePlayMessage;
    private string apnsCollapseId;
    private int contentAvailable;
    private string category;
    private string autoBadge;
    private AlertMsg alertMsg;

    public int VoicePlayType
    {
      get
      {
        return this.voicePlayType;
      }
      set
      {
        this.voicePlayType = value;
      }
    }

    public string VoicePlayMessage
    {
      get
      {
        return this.voicePlayMessage;
      }
      set
      {
        this.voicePlayMessage = value;
      }
    }

    public string getApnsCollapseId()
    {
      return this.apnsCollapseId;
    }

    public Dictionary<string, object> CustomMsg
    {
      get
      {
        return this.customMsg;
      }
      set
      {
        this.customMsg = value;
      }
    }

    public void addCustomMsg(string key, object value)
    {
      if (string.IsNullOrEmpty(key) || value == null)
        return;
      this.customMsg.Add(key, value);
    }

    public int Badge
    {
      get
      {
        return this.badge;
      }
      set
      {
        if (value <= 0)
          return;
        this.badge = value;
      }
    }

    public string Sound
    {
      get
      {
        return this.sound;
      }
      set
      {
        if (string.IsNullOrEmpty(value))
          this.sound = "default";
        else
          this.sound = value;
      }
    }

    public int ContentAvailable
    {
      get
      {
        return this.contentAvailable;
      }
      set
      {
        if (value <= 0)
          return;
        this.contentAvailable = value;
      }
    }

    public string Category
    {
      get
      {
        return this.category;
      }
      set
      {
        this.category = value;
      }
    }

    public AlertMsg AlertMsg
    {
      get
      {
        return this.alertMsg;
      }
      set
      {
        this.alertMsg = value;
      }
    }

    public List<MultiMedia> MultiMedias
    {
      get
      {
        return this.multiMedias;
      }
      set
      {
        this.multiMedias = value;
      }
    }

    public string getAutoBadge()
    {
      return this.autoBadge;
    }

    public APNPayload setAutoBadge(string autoBadge)
    {
      Match match = Regex.Match(autoBadge, "^(-|\\+)?\\d+$");
      if (autoBadge == null || !match.Success)
        throw new Exception("autoBadge invalid");
      this.autoBadge = autoBadge;
      return this;
    }

    public string getPayload()
    {
      try
      {
        Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
        if (this.alertMsg != null && APNPayload.isNotEmpty(this.alertMsg.getAlertMsg()))
          dictionary1.Add("alert", this.alertMsg.getAlertMsg());
        if (this.autoBadge != null)
          dictionary1.Add("autoBadge", (object) this.autoBadge);
        else if (this.badge >= 0)
          dictionary1.Add("badge", (object) this.badge);
        if ("com.gexin.ios.silence" != this.sound)
          dictionary1.Add("sound", (object) this.sound);
        if (!APNPayload.isNotEmpty((object) dictionary1))
          throw new Exception("format error");
        if (this.contentAvailable > 0)
          dictionary1.Add("content-available", (object) this.contentAvailable);
        if (APNPayload.isNotEmpty((object) this.category))
          dictionary1.Add("category", (object) this.category);
        Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
        foreach (KeyValuePair<string, object> keyValuePair in this.customMsg)
          dictionary2.Add(keyValuePair.Key, keyValuePair.Value);
        dictionary2.Add("aps", (object) dictionary1);
        if (this.apnsCollapseId != null)
          dictionary2.Add("apns-collapse-id", (object) this.apnsCollapseId);
        if (this.multiMedias != null && this.multiMedias.Count > 0)
          dictionary2.Add("_grinfo_", (object) this.checkMultiMedias());
        if (this.voicePlayType == 1)
          dictionary2.Add("_gvp_t_", (object) 1);
        else if (this.voicePlayType == 2 && string.IsNullOrEmpty(this.voicePlayMessage))
        {
          dictionary2.Add("_gvp_t_", (object) 2);
          dictionary2.Add("_gvp_m_", (object) this.voicePlayMessage);
        }
        return JsonConvert.SerializeObject((object) dictionary2);
      }
      catch (Exception ex)
      {
        throw new Exception("create apn payload error", ex);
      }
    }

    public void setApnsCollapseId(string apnsCollapseId)
    {
      if (string.IsNullOrEmpty(apnsCollapseId))
        return;
      this.apnsCollapseId = apnsCollapseId;
    }

    private List<MultiMedia> checkMultiMedias()
    {
      if (this.multiMedias.Count > 3)
        throw new Exception("MultiMedias size overlimit");
      bool flag1 = false;
      HashSet<string> stringSet = new HashSet<string>();
      foreach (MultiMedia multiMedia in this.multiMedias)
      {
        if (multiMedia.rid == null)
          flag1 = true;
        else
          stringSet.Add(multiMedia.rid);
        bool flag2 = false;
        foreach (MultiMedia.MediaType mediaType in Enum.GetValues(typeof (MultiMedia.MediaType)))
        {
          if (mediaType.Equals((object) multiMedia.type))
            flag2 = true;
        }
        if (!flag2 || multiMedia.url == null)
          throw new Exception("MultiMedia resType and resUrl can't be null");
      }
      if (stringSet.Count != this.multiMedias.Count)
        flag1 = true;
      int num = 0;
      if (flag1)
      {
        foreach (MultiMedia multiMedia in this.multiMedias)
          multiMedia.rid = "grid-" + (object) num++;
      }
      return this.multiMedias;
    }

    private static bool isNotEmpty(object item)
    {
      return item != null && (item is string && (string) item != "" || item is Array && ((Array) item).Length > 0 || (item is List<string> && ((List<string>) item).Count > 0 || item is Dictionary<string, object> && ((Dictionary<string, object>) item).Count > 0));
    }
  }
}
