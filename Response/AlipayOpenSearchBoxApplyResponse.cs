using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenSearchBoxApplyResponse.
    /// </summary>
    public class AlipayOpenSearchBoxApplyResponse : AopResponse
    {
        /// <summary>
        /// 搜索直达配置id
        /// </summary>
        [XmlElement("box_id")]
        public string BoxId { get; set; }
    }
}
