using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenAppNotifyVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppNotifyVerifyModel : AopObject
    {
        /// <summary>
        /// 通知id
        /// </summary>
        [XmlElement("notify_id")]
        public string NotifyId { get; set; }
    }
}
