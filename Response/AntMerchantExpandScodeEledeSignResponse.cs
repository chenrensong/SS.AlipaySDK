using System;
using System.Xml.Serialization;
using SS.AlipaySDKaySDK.Domain;

namespace SS.AlipaySDKaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandScodeEledeSignResponse.
    /// </summary>
    public class AntMerchantExpandScodeEledeSignResponse : AopResponse
    {
        /// <summary>
        /// 打标接口返回结果
        /// </summary>
        [XmlElement("add_tag_response")]
        public AddTagResponse AddTagResponse { get; set; }
    }
}
