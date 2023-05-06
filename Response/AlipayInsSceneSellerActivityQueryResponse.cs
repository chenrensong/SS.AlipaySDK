using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneSellerActivityQueryResponse.
    /// </summary>
    public class AlipayInsSceneSellerActivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 关于签约查询结果的告知
        /// </summary>
        [XmlElement("ins_seller_activity")]
        public InsSellerActivity InsSellerActivity { get; set; }
    }
}
