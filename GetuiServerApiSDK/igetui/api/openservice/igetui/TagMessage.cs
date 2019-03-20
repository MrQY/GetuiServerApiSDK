using System.Collections.Generic;

namespace com.igetui.api.openservice.igetui
{
  public class TagMessage : Message
  {
    private List<string> appIdList;
    private string tag;
    private int speed;

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

    public string Tag
    {
      get
      {
        return this.tag;
      }
      set
      {
        this.tag = value;
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
