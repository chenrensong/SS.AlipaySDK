using System;
using System.Xml.Serialization;
using SS.AlipaySDKaySDK.Domain;

namespace SS.AlipaySDKaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandScodeModifyResponse.
    /// </summary>
    public class AntMerchantExpandScodeModifyResponse : AopResponse
    {
        /// <summary>
        /// 更新码值返回结果
        /// </summary>
        [XmlElement("update_code_response")]
        public UpdateCodeResponse UpdateCodeResponse { get; set; }
    }
}
