using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandDeliveryProcessSyncResponse.
    /// </summary>
    public class AntMerchantExpandDeliveryProcessSyncResponse : AopResponse
    {
        /// <summary>
        /// 响应参数
        /// </summary>
        [XmlElement("result")]
        public AssetResult Result { get; set; }
    }
}
