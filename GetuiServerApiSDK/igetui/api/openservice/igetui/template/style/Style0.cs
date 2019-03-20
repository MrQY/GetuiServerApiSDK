using com.gexin.rp.sdk.dto;

namespace com.igetui.api.openservice.igetui.template.style
{
  public class Style0 : AbstractNotifyStyle
  {
    private string logo = "";
    private string logoUrl = "";
    private new bool isRing = true;
    private new bool isVibrate = true;
    private new bool isClearable = true;
    private string text;
    private string title;

    public string Text
    {
      get
      {
        return this.text;
      }
      set
      {
        this.text = value;
      }
    }

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

    public string LogoUrl
    {
      get
      {
        return this.logoUrl;
      }
      set
      {
        this.logoUrl = value;
      }
    }

    public new bool IsRing
    {
      get
      {
        return this.isRing;
      }
      set
      {
        this.isRing = value;
      }
    }

    public new bool IsVibrate
    {
      get
      {
        return this.isVibrate;
      }
      set
      {
        this.isVibrate = value;
      }
    }

    public new bool IsClearable
    {
      get
      {
        return this.isClearable;
      }
      set
      {
        this.isClearable = value;
      }
    }

    public override ActionChain getActionChain()
    {
      return this.actionChainBuilder.AddField(InnerFiled.CreateBuilder().SetKey("title").SetVal(this.title).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("text").SetVal(this.text).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(this.logo).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo_url").SetVal(this.logoUrl).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("notifyStyle").SetVal("0").SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noring").SetVal((!this.isRing).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noclear").SetVal((!this.isClearable).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_novibrate").SetVal((!this.isVibrate).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).Build();
    }
  }
}
