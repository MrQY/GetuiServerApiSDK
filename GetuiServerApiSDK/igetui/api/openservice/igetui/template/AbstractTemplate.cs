using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.notify;
using com.igetui.api.openservice.payload;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace com.igetui.api.openservice.igetui.template
{
  public class AbstractTemplate : ITemplate
  {
    private PushInfo.Builder pushInfo = PushInfo.CreateBuilder().SetInvalidAPN(true).SetInvalidMPN(true);
    private Regex reg = new Regex("^(intent:#Intent;).*(;end)$");
    private string appId;
    private string appKey;
    private com.gexin.rp.sdk.dto.SmsInfo smsInfo;
    private string duration;
    private Transparent transparent;

    public string AppId
    {
      get
      {
        return this.appId;
      }
      set
      {
        this.appId = value;
      }
    }

    public string AppKey
    {
      get
      {
        return this.appKey;
      }
      set
      {
        this.appKey = value;
      }
    }

    public Transparent getTransparent()
    {
      if (this.transparent == null)
      {
        Transparent.Builder builder = Transparent.CreateBuilder().SetId("").SetTemplateId(this.getTemplateId()).SetMessageId("").SetTaskId("").SetAction("pushmessage").AddRangeActionChain((IEnumerable<ActionChain>) this.getActionChain()).SetPushInfo(this.pushInfo).SetAppId(this.appId).SetAppKey(this.appKey).AddCondition(this.getDurCondition());
        if (this.smsInfo != null)
          builder.SetSmsInfo(this.smsInfo);
        this.transparent = builder.Build();
      }
      return this.transparent;
    }

    private string getDurCondition()
    {
      if (this.duration == null || this.duration.Equals(""))
        return "";
      return "duration=" + this.duration;
    }

    public virtual string getTransmissionContent()
    {
      return "";
    }

    public virtual string getPushType()
    {
      return "";
    }

    public virtual List<ActionChain> getActionChain()
    {
      return (List<ActionChain>) null;
    }

    public PushInfo getPushInfo()
    {
      return this.pushInfo.Build();
    }

    protected PushInfo.Builder getPushInfoBuilder()
    {
      return this.pushInfo;
    }

    public void setAPNInfo(Payload apn)
    {
      if (apn == null)
        return;
      string payload = apn.getPayload();
      if (payload == null || payload.Equals(""))
        return;
      int length = Encoding.UTF8.GetBytes(payload).Length;
      if (length > 2048)
        throw new Exception("APN payload size overlength (" + (object) length + ">" + (object) 2048 + ")");
      this.pushInfo.SetApnJson(payload).SetInvalidAPN(false);
    }

    public void setPushInfo(
      string actionLocKey,
      int badge,
      string message,
      string sound,
      string payload,
      string locKey,
      string locArgs,
      string launchImage)
    {
      this.setPushInfo(actionLocKey, badge, message, sound, payload, locKey, locArgs, launchImage, 0);
    }

    public void setPushInfo(
      string actionLocKey,
      int badge,
      string message,
      string sound,
      string payload,
      string locKey,
      string locArgs,
      string launchImage,
      int contentAvailable)
    {
      APNPayload apnPayload = new APNPayload();
      DictionaryAlertMsg dictionaryAlertMsg = new DictionaryAlertMsg();
      dictionaryAlertMsg.ActionLocKey = actionLocKey;
      dictionaryAlertMsg.Body = message;
      dictionaryAlertMsg.LocKey = locKey;
      dictionaryAlertMsg.addLocArg(locArgs);
      dictionaryAlertMsg.LaunchImage = launchImage;
      apnPayload.AlertMsg = (AlertMsg) dictionaryAlertMsg;
      apnPayload.Badge = badge;
      apnPayload.Sound = sound;
      if (string.IsNullOrEmpty(payload))
        apnPayload.addCustomMsg(nameof (payload), (object) payload);
      apnPayload.ContentAvailable = contentAvailable;
      this.setAPNInfo((Payload) apnPayload);
    }

    public void setDuration(string begin, string end)
    {
      long num1 = (Convert.ToDateTime(begin).Ticks - 621356256000000000L) / 10000L;
      long num2 = (Convert.ToDateTime(end).Ticks - 621356256000000000L) / 10000L;
      if (num1 <= 0L || num2 <= 0L)
        throw new Exception("DateFormat: yyyy-MM-dd hh:mm:ss");
      if (num1 > num2)
        throw new Exception("startTime should be smaller than endTime");
      this.duration = num1.ToString() + "-" + (object) num2;
    }

    public void set3rdNotifyInfo(Notify notify)
    {
      if (notify.Title == null || notify.Content == null)
        throw new Exception("notify title or content cannot be null");
      NotifyInfo.Builder builder = NotifyInfo.CreateBuilder().SetTitle(notify.Title).SetContent(notify.Content);
      if (this.typeNotNull(notify.Type))
      {
        builder.SetType(notify.Type);
        if (!string.IsNullOrEmpty(notify.Payload))
          builder.SetPayload(notify.Payload);
        if (!string.IsNullOrEmpty(notify.Intent))
        {
          if (notify.Intent.Length > GtConfig.getTransIntentLength())
            throw new Exception("intent size overlimit " + (object) GtConfig.getTransIntentLength());
          if (!this.reg.IsMatch(notify.Intent))
            throw new Exception("intent format error,should start with \"intent:#Intent;\",end with \";end\" ");
          builder.SetIntent(notify.Intent);
        }
        if (!string.IsNullOrEmpty(notify.Url))
          builder.SetUrl(notify.Url);
      }
      this.pushInfo.SetNotifyInfo(builder.Build()).SetValidNotify(true);
    }

    public void setSmsInfo(com.igetui.api.openservice.igetui.sms.SmsInfo smsInfo)
    {
      if (smsInfo == null)
        throw new Exception("smsInfo cannot be empty");
      string smsTemplateId = smsInfo.SmsTemplateId;
      Dictionary<string, string> smsContent = smsInfo.SmsContent;
      long offlineSendtime = smsInfo.OfflineSendtime;
      long num = 0;
      if (string.IsNullOrEmpty(smsTemplateId))
        throw new Exception("smsTemplateId cannot be empty");
      if (offlineSendtime == 0L)
        throw new Exception("offlineSendtime cannot be empty");
      com.gexin.rp.sdk.dto.SmsInfo.Builder builder = com.gexin.rp.sdk.dto.SmsInfo.CreateBuilder().SetSmsChecked(false).SetSmsTemplateId(smsTemplateId).SetOfflineSendtime(offlineSendtime).SetSmsSendDuration(num);
      if (smsInfo.IsApplink)
      {
        if (smsInfo.SmsContent != null && smsInfo.SmsContent.ContainsKey("url") && !string.IsNullOrEmpty(smsInfo.SmsContent["url"]))
          throw new Exception("SmsContent cann not contains key about url");
        builder.AddSmsContent(SmsContentEntry.CreateBuilder().SetKey("applinkIdentification").SetValue("1"));
        string payload = smsInfo.Payload;
        if (payload != null)
          builder.AddSmsContent(SmsContentEntry.CreateBuilder().SetKey("url").SetValue(smsInfo.Url + "?n=" + payload + "&p="));
        else
          builder.AddSmsContent(SmsContentEntry.CreateBuilder().SetKey("url").SetValue(smsInfo.Url + "?p="));
      }
      if (smsContent != null)
      {
        foreach (KeyValuePair<string, string> keyValuePair in smsContent)
        {
          if (string.IsNullOrEmpty(keyValuePair.Key) || string.IsNullOrEmpty(keyValuePair.Value))
            throw new Exception("smsContent entry cannot be null");
          builder.AddSmsContent(SmsContentEntry.CreateBuilder().SetKey(keyValuePair.Key).SetValue(keyValuePair.Value));
        }
      }
      this.smsInfo = builder.Build();
    }

    private bool typeNotNull(NotifyInfo.Types.Type type)
    {
      bool flag = false;
      foreach (NotifyInfo.Types.Type type1 in Enum.GetValues(typeof (NotifyInfo.Types.Type)))
      {
        if (type1.Equals((object) type))
          flag = true;
      }
      return flag;
    }

    protected virtual int getTemplateId()
    {
      return -1;
    }
  }
}
