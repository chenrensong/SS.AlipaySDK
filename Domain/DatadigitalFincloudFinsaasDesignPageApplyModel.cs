using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPageApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasDesignPageApplyModel : AopObject
    {
        /// <summary>
        /// 修改的数据
        /// </summary>
        [XmlElement("page_info")]
        public PageInfoDTO PageInfo { get; set; }
    }
}
