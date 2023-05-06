using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// CustomerDefineVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerDefineVoucherInfo : AopObject
    {
        /// <summary>
        /// 优惠信息
        /// </summary>
        [XmlElement("deduct_info")]
        public DeductInfo DeductInfo { get; set; }
    }
}
