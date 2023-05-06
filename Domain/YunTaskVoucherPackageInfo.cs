using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// YunTaskVoucherPackageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class YunTaskVoucherPackageInfo : AopObject
    {
        /// <summary>
        /// 券包名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 券包id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }
    }
}
