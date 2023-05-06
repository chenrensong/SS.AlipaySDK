using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceSportsOnlinegameUsergameSyncResponse.
    /// </summary>
    public class AlipayCommerceSportsOnlinegameUsergameSyncResponse : AopResponse
    {
        /// <summary>
        /// 用户参赛信息
        /// </summary>
        [XmlElement("user_online_game_info")]
        public UserOnlineGameInfo UserOnlineGameInfo { get; set; }
    }
}
