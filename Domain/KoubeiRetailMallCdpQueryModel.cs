using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// KoubeiRetailMallCdpQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailMallCdpQueryModel : AopObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }
    }
}
