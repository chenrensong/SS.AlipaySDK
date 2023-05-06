using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiDeliverQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiDeliverQueryModel : AopObject
    {
        /// <summary>
        /// 业务参数
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }
    }
}
