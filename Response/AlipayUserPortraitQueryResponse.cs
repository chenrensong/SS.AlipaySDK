using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserPortraitQueryResponse.
    /// </summary>
    public class AlipayUserPortraitQueryResponse : AopResponse
    {
        /// <summary>
        /// 拼团信息列表
        /// </summary>
        [XmlArray("pintuan_user_infos")]
        [XmlArrayItem("pintuan_user_infos")]
        public List<PintuanUserInfos> PintuanUserInfos { get; set; }
    }
}
