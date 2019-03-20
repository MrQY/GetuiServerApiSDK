using com.gexin.rp.sdk.dto;

namespace com.igetui.api.openservice
{
  public interface ITemplate
  {
    Transparent getTransparent();

    string getTransmissionContent();

    string getPushType();

    PushInfo getPushInfo();
  }
}
