using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayUserDtbankcustChannelvoucherconfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankcustChannelvoucherconfigQueryModel : AopObject
    {
        /// <summary>
        /// 在开放活动平台配置活动的唯一id，唯一标志一个活动
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
