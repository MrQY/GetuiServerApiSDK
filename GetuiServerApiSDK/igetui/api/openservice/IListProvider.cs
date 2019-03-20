using com.igetui.api.openservice.igetui;
using System.Collections.Generic;

namespace com.igetui.api.openservice
{
  public interface IListProvider
  {
    List<Target> getClientList(int page);
  }
}
