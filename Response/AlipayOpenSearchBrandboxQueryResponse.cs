using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenSearchBrandboxQueryResponse.
    /// </summary>
    public class AlipayOpenSearchBrandboxQueryResponse : AopResponse
    {
        /// <summary>
        /// 品牌box详情
        /// </summary>
        [XmlElement("data")]
        public SearchBrandBoxInfo Data { get; set; }
    }
}
