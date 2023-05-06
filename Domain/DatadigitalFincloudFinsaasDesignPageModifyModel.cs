using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPageModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasDesignPageModifyModel : AopObject
    {
        /// <summary>
        /// 更新的页面详情
        /// </summary>
        [XmlElement("page_info")]
        public PageInfoDTO PageInfo { get; set; }
    }
}
