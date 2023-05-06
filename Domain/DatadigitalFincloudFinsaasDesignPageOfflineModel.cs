using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPageOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasDesignPageOfflineModel : AopObject
    {
        /// <summary>
        /// 修改的信息
        /// </summary>
        [XmlElement("page_info")]
        public PageInfoDTO PageInfo { get; set; }
    }
}
