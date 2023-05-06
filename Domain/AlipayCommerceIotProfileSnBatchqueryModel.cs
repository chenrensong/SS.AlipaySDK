using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceIotProfileSnBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotProfileSnBatchqueryModel : AopObject
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("apply_id")]
        public long ApplyId { get; set; }
    }
}
