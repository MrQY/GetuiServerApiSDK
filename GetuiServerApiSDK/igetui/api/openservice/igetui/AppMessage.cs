using System.Collections.Generic;

namespace com.igetui.api.openservice.igetui
{
  public class AppMessage : Message
  {
    private List<string> phoneTypeList = new List<string>();
    private List<string> provinceList = new List<string>();
    private List<string> tagList = new List<string>();
    private List<string> appIdList;
    private int speed;
    private string pushTime;
    private AppConditions conditions;

    public AppConditions Conditions
    {
      get
      {
        return this.conditions;
      }
      set
      {
        this.conditions = value;
      }
    }

    public string PushTime
    {
      get
      {
        return this.pushTime;
      }
      set
      {
        this.pushTime = value;
      }
    }

    public List<string> TagList
    {
      get
      {
        return this.tagList;
      }
      set
      {
        this.tagList = value;
      }
    }

    public List<string> AppIdList
    {
      get
      {
        return this.appIdList;
      }
      set
      {
        this.appIdList = value;
      }
    }

    public List<string> PhoneTypeList
    {
      get
      {
        return this.phoneTypeList;
      }
      set
      {
        this.phoneTypeList = value;
      }
    }

    public List<string> ProvinceList
    {
      get
      {
        return this.provinceList;
      }
      set
      {
        this.provinceList = value;
      }
    }

    public int Speed
    {
      get
      {
        return this.speed;
      }
      set
      {
        this.speed = value;
      }
    }
  }
}
