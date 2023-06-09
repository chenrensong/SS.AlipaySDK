using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosShiftQueryResponse.
    /// </summary>
    public class KoubeiCateringPosShiftQueryResponse : AopResponse
    {
        /// <summary>
        /// 班次信息列表
        /// </summary>
        [XmlArray("shop_pos_schedules")]
        [XmlArrayItem("shop_pos_schedule")]
        public List<ShopPosSchedule> ShopPosSchedules { get; set; }
    }
}
