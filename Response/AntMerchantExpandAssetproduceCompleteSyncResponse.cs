using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandAssetproduceCompleteSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetproduceCompleteSyncResponse : AopResponse
    {
        /// <summary>
        /// 物料订单更新结果信息
        /// </summary>
        [XmlArray("asset_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> AssetResults { get; set; }
    }
}
