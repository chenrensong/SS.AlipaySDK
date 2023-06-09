using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvMachinegoodsAddResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvMachinegoodsAddResponse : AopResponse
    {
        /// <summary>
        /// 柜内区域状态
        /// </summary>
        [XmlArray("regions")]
        [XmlArrayItem("region_state")]
        public List<RegionState> Regions { get; set; }
    }
}
