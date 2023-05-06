using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandAssetBomQueryResponse.
    /// </summary>
    public class AntMerchantExpandAssetBomQueryResponse : AopResponse
    {
        /// <summary>
        /// 物料清单信息
        /// </summary>
        [XmlElement("asset_bom")]
        public AssetBom AssetBom { get; set; }
    }
}
