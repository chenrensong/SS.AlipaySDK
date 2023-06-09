using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorUnfreezeResponse.
    /// </summary>
    public class KoubeiMerchantOperatorUnfreezeResponse : AopResponse
    {
        /// <summary>
        /// 操作结果 true: success, false: failed
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
