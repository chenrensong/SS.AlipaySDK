using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayUserApplepayProvisioningbundleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserApplepayProvisioningbundleCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_identifier")]
        public string AlipayUserIdentifier { get; set; }
    }
}
