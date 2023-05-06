using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockBizQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockBizQueryModel : AopObject
    {
        /// <summary>
        /// 业务编码
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("number")]
        public string Number { get; set; }
    }
}
