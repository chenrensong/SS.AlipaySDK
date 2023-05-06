using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandAssetinfoCorrectionSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetinfoCorrectionSyncResponse : AopResponse
    {
        /// <summary>
        /// 物料更正请求响应。
        /// </summary>
        [XmlArray("correction_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> CorrectionResults { get; set; }
    }
}
