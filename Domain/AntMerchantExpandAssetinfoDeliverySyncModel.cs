using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetinfoDeliverySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetinfoDeliverySyncModel : AopObject
    {
        /// <summary>
        /// 传入需要反馈的物料信息对象列表。
        /// </summary>
        [XmlArray("asset_infos")]
        [XmlArrayItem("asset_info_item")]
        public List<AssetInfoItem> AssetInfos { get; set; }
    }
}
