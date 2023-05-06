using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdUserbalanceOfflineResponse.
    /// </summary>
    public class AlipayDataDataserviceAdUserbalanceOfflineResponse : AopResponse
    {
        /// <summary>
        /// 操作成功投放账户id列表
        /// </summary>
        [XmlArray("success_user_id_list")]
        [XmlArrayItem("string")]
        public List<string> SuccessUserIdList { get; set; }
    }
}
