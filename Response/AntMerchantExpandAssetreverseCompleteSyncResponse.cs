using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandAssetreverseCompleteSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetreverseCompleteSyncResponse : AopResponse
    {
        /// <summary>
        /// 取消订单或者退货已经完成时，响应参数
        /// </summary>
        [XmlArray("asset_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> AssetResults { get; set; }
    }
}
