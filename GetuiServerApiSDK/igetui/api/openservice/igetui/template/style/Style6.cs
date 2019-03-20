using com.gexin.rp.sdk.dto;

namespace com.igetui.api.openservice.igetui.template.style
{
  public class Style6 : AbstractNotifyStyle
  {
    private string logo = "";
    private string logoUrl = "";
    private string bigStyle = "";
    private string bigImageUrl = "";
    private string bigText = "";
    private string bannerUrl = "";
    private string text;
    private string title;

    public string BigStyle
    {
      get
      {
        return this.bigStyle;
      }
      set
      {
        this.bigStyle = value;
      }
    }

    public string BigImageUrl
    {
      get
      {
        return this.bigImageUrl;
      }
      set
      {
        this.bigImageUrl = value;
      }
    }

    public string BigText
    {
      get
      {
        return this.bigText;
      }
      set
      {
        this.bigText = value;
      }
    }

    public string BannerUrl
    {
      get
      {
        return this.bannerUrl;
      }
      set
      {
        this.bannerUrl = value;
      }
    }

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

    public void setBigStyle1(string bigImageUrl)
    {
      this.bigStyle = "1";
      this.bigImageUrl = bigImageUrl;
    }

    public void setBigStyle2(string bigText)
    {
      this.bigStyle = "2";
      this.bigText = bigText;
    }

    public void setBigStyle3(string bigImageUrl, string bannerUrl)
    {
      this.bigStyle = "3";
      this.bigImageUrl = bigImageUrl;
      this.bannerUrl = bannerUrl;
    }

    public override ActionChain getActionChain()
    {
      return this.actionChainBuilder.AddField(InnerFiled.CreateBuilder().SetKey("title").SetVal(this.title).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("text").SetVal(this.text).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(this.logo).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo_url").SetVal(this.logoUrl).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("notifyStyle").SetVal("6").SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noring").SetVal((!this.isRing).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noclear").SetVal((!this.isClearable).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_novibrate").SetVal((!this.isVibrate).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("bigStyle").SetVal(this.bigStyle).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("big_image_url").SetVal(this.bigImageUrl).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("banner_url").SetVal(this.bannerUrl).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("big_text").SetVal(this.bigText).SetType(InnerFiled.Types.Type.str).Build()).Build();
    }
  }
}
