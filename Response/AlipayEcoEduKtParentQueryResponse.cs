using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEcoEduKtParentQueryResponse.
    /// </summary>
    public class AlipayEcoEduKtParentQueryResponse : AopResponse
    {
        /// <summary>
        /// 如果用户已经添加过这个孩子，则返回SUCCESS ， 失败返回FAIL。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
