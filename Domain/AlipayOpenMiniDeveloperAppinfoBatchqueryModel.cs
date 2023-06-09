using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenMiniDeveloperAppinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniDeveloperAppinfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 客户端标识
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }
    }
}
