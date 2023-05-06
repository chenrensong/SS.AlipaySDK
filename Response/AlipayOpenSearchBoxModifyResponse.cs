using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenSearchBoxModifyResponse.
    /// </summary>
    public class AlipayOpenSearchBoxModifyResponse : AopResponse
    {
        /// <summary>
        /// 搜索直达模块配置id
        /// </summary>
        [XmlElement("module_id")]
        public string ModuleId { get; set; }
    }
}
