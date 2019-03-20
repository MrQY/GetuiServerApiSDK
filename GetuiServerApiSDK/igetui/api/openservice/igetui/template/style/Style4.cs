using com.gexin.rp.sdk.dto;

namespace com.igetui.api.openservice.igetui.template.style
{
  public class Style4 : AbstractNotifyStyle
  {
    private string logo = "";
    private string banner_url = "";

    public string Logo
    {
      get
      {
        return this.logo;
      }
      set
      {
        this.logo = value;
      }
    }

    public string Banner_url
    {
      get
      {
        return this.banner_url;
      }
      set
      {
        this.banner_url = value;
      }
    }

    public override ActionChain getActionChain()
    {
      return this.actionChainBuilder.AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(this.logo).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("banner_url").SetVal(this.banner_url).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noring").SetVal((!this.isRing).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noclear").SetVal((!this.isClearable).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_novibrate").SetVal((!this.isVibrate).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("notifyStyle").SetVal("4").SetType(InnerFiled.Types.Type.str).Build()).Build();
    }
  }
}
