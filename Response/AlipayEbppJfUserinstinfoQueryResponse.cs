using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppJfUserinstinfoQueryResponse.
    /// </summary>
    public class AlipayEbppJfUserinstinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 机构信息列表
        /// </summary>
        [XmlArray("user_charge_inst_info_list")]
        [XmlArrayItem("ebpp_user_charge_inst_info")]
        public List<EbppUserChargeInstInfo> UserChargeInstInfoList { get; set; }
    }
}
