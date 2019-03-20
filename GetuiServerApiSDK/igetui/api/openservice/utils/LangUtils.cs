using System;
using System.Text.RegularExpressions;

namespace com.igetui.api.openservice.utils
{
  internal class LangUtils
  {
    private static Regex REGEX = new Regex("^(?:(?!0000)[0-9]{4}(?:(?:0[1-9]|1[0-2])(?:0[1-9]|1[0-9]|2[0-8])|(?:0[13-9]|1[0-2])(?:29|30)|(?:0[13578]|1[02])31)|(?:[0-9]{2}(?:0[48]|[2468][048]|[13579][26])|(?:0[48]|[2468][048]|[13579][26])00)0229)$");

    public static bool validateDate(string date)
    {
      if (date == null || !LangUtils.REGEX.IsMatch(date))
        return false;
      return DateTime.ParseExact(date, "yyyyMMdd", (IFormatProvider) null) < DateTime.Now;
    }
  }
}
