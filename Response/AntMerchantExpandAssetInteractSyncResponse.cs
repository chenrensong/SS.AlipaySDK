using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandAssetInteractSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetInteractSyncResponse : AopResponse
    {
        /// <summary>
        /// 回调结果
        /// </summary>
        [XmlArray("asset_callback_results")]
        [XmlArrayItem("asset_callback_info")]
        public List<AssetCallbackInfo> AssetCallbackResults { get; set; }
    }
}
