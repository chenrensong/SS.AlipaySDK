using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoriteQueryResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappFavoriteQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户是否已收藏调用方的小程序
        /// </summary>
        [XmlElement("favorite")]
        public bool Favorite { get; set; }
    }
}
