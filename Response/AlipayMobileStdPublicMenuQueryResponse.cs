using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMobileStdPublicMenuQueryResponse.
    /// </summary>
    public class AlipayMobileStdPublicMenuQueryResponse : AopResponse
    {
        /// <summary>
        /// 所有菜单列表json串
        /// </summary>
        [XmlElement("all_menu_list")]
        public string AllMenuList { get; set; }
    }
}
