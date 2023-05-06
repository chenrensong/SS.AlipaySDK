using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceSportsOnlinegameGameSyncResponse.
    /// </summary>
    public class AlipayCommerceSportsOnlinegameGameSyncResponse : AopResponse
    {
        /// <summary>
        /// 线上赛事信息
        /// </summary>
        [XmlElement("online_game_info")]
        public OnlineGameInfo OnlineGameInfo { get; set; }
    }
}
