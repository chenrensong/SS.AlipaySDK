using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandAssetproduceAssignSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetproduceAssignSyncResponse : AopResponse
    {
        /// <summary>
        /// 供应商处理生产指令结果
        /// </summary>
        [XmlArray("asset_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> AssetResults { get; set; }
    }
}
