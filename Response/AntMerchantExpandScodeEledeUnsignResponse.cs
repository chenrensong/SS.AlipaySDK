using System;
using System.Xml.Serialization;
using SS.AlipaySDKaySDK.Domain;

namespace SS.AlipaySDKaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandScodeEledeUnsignResponse.
    /// </summary>
    public class AntMerchantExpandScodeEledeUnsignResponse : AopResponse
    {
        /// <summary>
        /// 去标返回结果
        /// </summary>
        [XmlElement("remove_tag_response")]
        public RemoveTagResponse RemoveTagResponse { get; set; }
    }
}
