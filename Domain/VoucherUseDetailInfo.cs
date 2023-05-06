using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// VoucherUseDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseDetailInfo : AopObject
    {
        /// <summary>
        /// 本次核销次数
        /// </summary>
        [XmlElement("voucher_use_times")]
        public long VoucherUseTimes { get; set; }
    }
}
