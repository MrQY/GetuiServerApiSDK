using System.Collections.Generic;

namespace com.igetui.api.openservice.igetui
{
  public class AppConditions
  {
    public static string PHONE_TYPE = "phoneType";
    public static string REGION = "region";
    public static string TAG = "tag";
    private List<Dictionary<string, object>> condition = new List<Dictionary<string, object>>();

    public AppConditions addCondition(string key, List<string> values, int optType)
    {
      this.condition.Add(new Dictionary<string, object>()
      {
        {
          nameof (key),
          (object) key
        },
        {
          nameof (values),
          (object) values
        },
        {
          nameof (optType),
          (object) optType
        }
      });
      return this;
    }

    public AppConditions addCondition(
      string key,
      List<string> values,
      AppConditions.OptType optType)
    {
      this.condition.Add(new Dictionary<string, object>()
      {
        {
          nameof (key),
          (object) key
        },
        {
          nameof (values),
          (object) values
        },
        {
          nameof (optType),
          (object) optType
        }
      });
      return this;
    }

    public AppConditions addCondition(string key, List<string> values)
    {
      return this.addCondition(key, values, 0);
    }

    public List<Dictionary<string, object>> getCondition()
    {
      return this.condition;
    }

    public enum OptType
    {
      or,
      and,
      not,
    }
  }
}
