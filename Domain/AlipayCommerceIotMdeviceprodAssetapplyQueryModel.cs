using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodAssetapplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodAssetapplyQueryModel : AopObject
    {
        /// <summary>
        /// 物料平台的申请单ID
        /// </summary>
        [XmlElement("apply_order_id")]
        public string ApplyOrderId { get; set; }
    }
}
