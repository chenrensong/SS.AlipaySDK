using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenAppNotifyRetryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppNotifyRetryModel : AopObject
    {
        /// <summary>
        /// notify_id_list+是+交易notifyId的列表
        /// </summary>
        [XmlArray("notify_id_list")]
        [XmlArrayItem("string")]
        public List<string> NotifyIdList { get; set; }
    }
}
