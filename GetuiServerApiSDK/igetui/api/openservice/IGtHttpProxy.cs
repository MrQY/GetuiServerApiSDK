namespace com.igetui.api.openservice
{
  public class IGtHttpProxy
  {
    private string _host;
    private int _port;
    private string _user;
    private string _passwd;

    public IGtHttpProxy()
    {
      string httpProxyIp = GtConfig.getHttpProxyIp();
      int httpProxyPort = GtConfig.getHttpProxyPort();
      if (string.IsNullOrWhiteSpace(httpProxyIp))
        return;
      this._host = httpProxyIp;
      this._port = httpProxyPort;
      this._user = GtConfig.getHttpProxyUser();
      this._passwd = GtConfig.getHttpProxyPasswd();
    }

    public string Host
    {
      get
      {
        return this._host;
      }
      set
      {
        this._host = value;
      }
    }

    public int Port
    {
      get
      {
        return this._port;
      }
      set
      {
        this._port = value;
      }
    }

    public string User
    {
      get
      {
        return this._user;
      }
      set
      {
        this._user = value;
      }
    }

    public string Password
    {
      get
      {
        return this._passwd;
      }
      set
      {
        this._passwd = value;
      }
    }
  }
}
