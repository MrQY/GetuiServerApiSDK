using System;
using System.Collections.Generic;

namespace com.igetui.api.openservice.payload
{
  public class DictionaryAlertMsg : AlertMsg
  {
    private List<string> titleLocArgs = new List<string>();
    private List<string> locArgs = new List<string>();
    private string title;
    private string body;
    private string titleLocKey;
    private string actionLocKey;
    private string locKey;
    private string launchImage;

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

    public string Body
    {
      get
      {
        return this.body;
      }
      set
      {
        this.body = value;
      }
    }

    public string TitleLocKey
    {
      get
      {
        return this.titleLocKey;
      }
      set
      {
        this.titleLocKey = value;
      }
    }

    public List<string> TitleLocArgs
    {
      get
      {
        return this.titleLocArgs;
      }
      set
      {
        this.titleLocArgs = value;
      }
    }

    public void addTitleLocArg(string titleLocArg)
    {
      if (string.IsNullOrEmpty(titleLocArg))
        return;
      this.titleLocArgs.Add(titleLocArg);
    }

    public string ActionLocKey
    {
      get
      {
        return this.actionLocKey;
      }
      set
      {
        this.actionLocKey = value;
      }
    }

    public string LocKey
    {
      get
      {
        return this.locKey;
      }
      set
      {
        this.locKey = value;
      }
    }

    public List<string> LocArgs
    {
      get
      {
        return this.locArgs;
      }
      set
      {
        this.locArgs = value;
      }
    }

    public void addLocArg(string locArg)
    {
      if (string.IsNullOrEmpty(locArg))
        return;
      this.locArgs.Add(locArg);
    }

    public string LaunchImage
    {
      get
      {
        return this.launchImage;
      }
      set
      {
        this.launchImage = value;
      }
    }

    public object getAlertMsg()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (DictionaryAlertMsg.isNotEmpty((object) this.title))
        dictionary.Add("title", (object) this.title);
      if (DictionaryAlertMsg.isNotEmpty((object) this.body))
        dictionary.Add("body", (object) this.body);
      if (DictionaryAlertMsg.isNotEmpty((object) this.titleLocKey))
        dictionary.Add("title-loc-key", (object) this.titleLocKey);
      if (DictionaryAlertMsg.isNotEmpty((object) this.titleLocArgs))
        dictionary.Add("title-loc-args", (object) this.titleLocArgs);
      if (DictionaryAlertMsg.isNotEmpty((object) this.actionLocKey))
        dictionary.Add("action-loc-key", (object) this.actionLocKey);
      if (DictionaryAlertMsg.isNotEmpty((object) this.locKey))
        dictionary.Add("loc-key", (object) this.locKey);
      if (DictionaryAlertMsg.isNotEmpty((object) this.locArgs))
        dictionary.Add("loc-args", (object) this.locArgs);
      if (DictionaryAlertMsg.isNotEmpty((object) this.launchImage))
        dictionary.Add("launch-image", (object) this.launchImage);
      return (object) dictionary;
    }

    private static bool isNotEmpty(object item)
    {
      return item != null && (item is string && (string) item != "" || item is Array && ((Array) item).Length > 0 || (item is List<string> && ((List<string>) item).Count > 0 || item is Dictionary<string, object> && ((Dictionary<string, object>) item).Count > 0));
    }
  }
}
