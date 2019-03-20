using com.igetui.api.openservice.igetui;
using System.Collections.Generic;

namespace com.igetui.api.openservice
{
  public interface IIGtPush
  {
    bool connect();

    void close();

    string pushMessageToSingle(SingleMessage message, Target target);

    void pushMessageToList(
      ListMessage message,
      IListProvider listProvider,
      IPushEventListener listener);

    string getContentId(ListMessage message);

    bool cancelContentId(string contentId);

    bool stop(string contentId);

    string pushMessageToList(string contentId, List<Target> targetList);

    string addCidListToBlk(string appId, List<string> cidList);

    string restoreCidListFromBlk(string appId, List<string> cidList);

    string pushMessageToApp(AppMessage message);

    string pushTagMessage(TagMessage message);

    string pushTagMessage(TagMessage message, string requestId);

    IBatch getBatch();

    string getUserCountByTags(string appId, List<string> tahlist);

    string getPushResultByTaskidList(List<string> taskIdList);

    string getPushActionResultByTaskids(List<string> taskIdList, List<string> actionIdList);

    string getScheduleTask(string taskId, string appId);

    string delScheduleTask(string taskId, string appId);

    string unbindCidPn(string appId, List<string> cid);

    string bindCidPn(string appId, Dictionary<string, string> cidAndPn);

    string queryCidPn(string appId, List<string> cid);

    string stopSendSms(string appId, string taskId);
  }
}
