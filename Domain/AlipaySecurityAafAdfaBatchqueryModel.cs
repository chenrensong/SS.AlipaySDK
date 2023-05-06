using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipaySecurityAafAdfaBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityAafAdfaBatchqueryModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }
    }
}
