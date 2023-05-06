using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AntMerchantExpandContractStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandContractStatusQueryModel : AopObject
    {
        /// <summary>
        /// 签约类型：商家开放签约枚举类型，固定值：AUTHORIZE_OPEN_PREPAID
        /// </summary>
        [XmlElement("sign_biz_from")]
        public string SignBizFrom { get; set; }
    }
}
