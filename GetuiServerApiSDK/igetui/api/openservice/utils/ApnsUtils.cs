using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.utils
{
  public static class ApnsUtils
  {
    public static int validatePayloadLength(
      string locKey,
      string locArgs,
      string message,
      string actionLocKey,
      string launchImage,
      string badge,
      string sound,
      string payload,
      int contentAvailable)
    {
      string s = ApnsUtils.processPayload(locKey, locArgs, message, actionLocKey, launchImage, badge, sound, payload, contentAvailable);
      try
      {
        return Encoding.UTF8.GetBytes(s).Length;
      }
      catch (Exception ex)
      {
        throw new Exception("payload json get bytese error", ex);
      }
    }

    public static bool validatePayload(
      string locKey,
      string locArgs,
      string message,
      string actionLocKey,
      string launchImage,
      string badge,
      string sound,
      string payload,
      int contentAvailable)
    {
      return ApnsUtils.validatePayloadLength(locKey, locArgs, message, actionLocKey, launchImage, badge, sound, payload, contentAvailable) <= 256;
    }

    private static string processPayload(
      string locKey,
      string locArgs,
      string message,
      string actionLocKey,
      string launchImage,
      string badge,
      string sound,
      string payload,
      int contentAvailable)
    {
      bool flag = false;
      ApnsUtils.Payload payload1 = new ApnsUtils.Payload();
      if (locKey != null && locKey.Length > 0)
      {
        payload1.AlertLocKey = locKey;
        if (locArgs != null && locArgs.Length > 0)
          payload1.AlertLocArgs = locArgs.Split(',');
        flag = true;
      }
      if (message != null && message.Length > 0)
      {
        payload1.AlertBody = message;
        flag = true;
      }
      if (actionLocKey != null && actionLocKey.Length > 0)
        payload1.AlertActionLocKey = actionLocKey;
      if (launchImage != null && launchImage.Length > 0)
        payload1.AlertLaunchImage = launchImage;
      int num;
      try
      {
        num = int.Parse(badge);
      }
      catch (Exception ex)
      {
        throw new Exception("unBindAlias失败 {0}", ex);
      }
      if (num >= 0)
      {
        payload1.Badge = num;
        flag = true;
      }
      payload1.Sound = string.IsNullOrEmpty(sound) ? "default" : sound;
      if (!string.IsNullOrEmpty(payload))
        payload1.addParam(nameof (payload), (object) payload);
      if (contentAvailable == 1)
        payload1.ContentAvailable = 1;
      if (!flag)
        throw new Exception("one of the params(locKey,message,badge) must not be null or contentAvailable must be 1");
      string str = payload1.ToString();
      if (str != null)
        return str;
      throw new Exception("payload json is null");
    }

    public class Payload
    {
      private static string APS = "aps";
      private string sound = "";
      private Dictionary<string, object> paramss;
      private string alert;
      private int badge;
      private string alertBody;
      private string alertActionLocKey;
      private string alertLocKey;
      private string[] alertLocArgs;
      private string alertLaunchImage;
      private int contentAvailable;

      public Dictionary<string, object> Paramss
      {
        get
        {
          return this.paramss;
        }
        set
        {
          this.paramss = value;
        }
      }

      public string Alert
      {
        get
        {
          return this.alert;
        }
        set
        {
          this.alert = value;
        }
      }

      public int Badge
      {
        get
        {
          return this.badge;
        }
        set
        {
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
          this.sound = value;
        }
      }

      public string AlertBody
      {
        get
        {
          return this.alertBody;
        }
        set
        {
          this.alertBody = value;
        }
      }

      public string AlertActionLocKey
      {
        get
        {
          return this.alertActionLocKey;
        }
        set
        {
          this.alertActionLocKey = value;
        }
      }

      public string AlertLocKey
      {
        get
        {
          return this.alertLocKey;
        }
        set
        {
          this.alertLocKey = value;
        }
      }

      public string[] AlertLocArgs
      {
        get
        {
          return this.alertLocArgs;
        }
        set
        {
          this.alertLocArgs = value;
        }
      }

      public string AlertLaunchImage
      {
        get
        {
          return this.alertLaunchImage;
        }
        set
        {
          this.alertLaunchImage = value;
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
          this.contentAvailable = value;
        }
      }

      public void addParam(string key, object obj)
      {
        if (this.paramss == null)
          this.paramss = new Dictionary<string, object>();
        if (ApnsUtils.Payload.APS.Equals(key.ToLower()))
          throw new Exception("the key can't be aps");
        this.paramss.Add(key, obj);
      }

      public override string ToString()
      {
        Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
        Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
        if (this.Alert != null)
          dictionary2.Add("alert", (object) this.Alert);
        else if (this.AlertBody != null || this.AlertLocKey != null)
        {
          Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
          this.putIntoJson("body", this.AlertBody, dictionary3);
          this.putIntoJson("action-loc-key", this.AlertActionLocKey, dictionary3);
          this.putIntoJson("loc-key", this.AlertLocKey, dictionary3);
          this.putIntoJson("launch-image", this.AlertLaunchImage, dictionary3);
          if (this.AlertLocArgs != null)
          {
            List<string> stringList = new List<string>();
            foreach (string alertLocArg in this.AlertLocArgs)
              stringList.Add(alertLocArg);
            dictionary3.Add("loc-args", (object) stringList);
          }
          dictionary2.Add("alert", (object) dictionary3);
        }
        dictionary2.Add("badge", (object) this.Badge);
        if (!"com.gexin.ios.silence".Equals(this.Sound))
          this.putIntoJson("sound", this.Sound, dictionary2);
        if (this.contentAvailable == 1)
          dictionary2.Add("content-available", (object) this.ContentAvailable);
        dictionary1.Add(ApnsUtils.Payload.APS, (object) dictionary2);
        if (this.Paramss != null)
        {
          foreach (KeyValuePair<string, object> keyValuePair in this.Paramss)
            dictionary1.Add(keyValuePair.Key, keyValuePair.Value);
        }
        try
        {
          return JsonConvert.SerializeObject((object) dictionary1);
        }
        catch (Exception ex)
        {
          throw new Exception("build apn payload json error", ex);
        }
      }

      private void putIntoJson(string key, string value, Dictionary<string, object> obj)
      {
        if (value == null)
          return;
        obj.Add(key, (object) value);
      }
    }
  }
}
