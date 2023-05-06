using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayAccountClearingcenterPayoffModifyResponse.
    /// </summary>
    public class AlipayAccountClearingcenterPayoffModifyResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public ClearingCommonResult Result { get; set; }
    }
}
