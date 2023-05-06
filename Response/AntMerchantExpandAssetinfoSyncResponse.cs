using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandAssetinfoSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 物料信息反馈处理结果
        /// </summary>
        [XmlArray("info_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> InfoResults { get; set; }
    }
}
