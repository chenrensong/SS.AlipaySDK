using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoriteAddResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappFavoriteAddResponse : AopResponse
    {
        /// <summary>
        /// 成功：true  失败：false
        /// </summary>
        [XmlElement("add_result")]
        public bool AddResult { get; set; }
    }
}
