using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAuthOperatorInfoQueryResponse.
    /// </summary>
    public class AlipayOpenAuthOperatorInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 操作员基础信息
        /// </summary>
        [XmlElement("operator_info")]
        public OperatorBasicInfo OperatorInfo { get; set; }
    }
}
