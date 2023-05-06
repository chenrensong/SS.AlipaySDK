using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// ZhimaMerchantContractOfferQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantContractOfferQueryModel : AopObject
    {
        /// <summary>
        /// 发约单单号
        /// </summary>
        [XmlElement("offer_no")]
        public string OfferNo { get; set; }
    }
}
