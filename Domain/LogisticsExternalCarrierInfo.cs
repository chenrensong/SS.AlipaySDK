using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// LogisticsExternalCarrierInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsExternalCarrierInfo : AopObject
    {
        /// <summary>
        /// 物流载体指定标识；  在CUPBOARD（取餐柜模式 场景）为指定设备号
        /// </summary>
        [XmlElement("carrier_no")]
        public string CarrierNo { get; set; }

        /// <summary>
        /// 物流载体状态：  WAIT_SIGN：待签收  SIGN：已签收  CANCELED：已撤销
        /// </summary>
        [XmlElement("carrier_status")]
        public string CarrierStatus { get; set; }

        /// <summary>
        /// 物流载体指定子物理标识；  在CUPBOARD（取餐柜模式 场景：该标识为格子物理编号，即格子唯一标识
        /// </summary>
        [XmlElement("carrier_sub_id")]
        public string CarrierSubId { get; set; }

        /// <summary>
        /// 物流载体指定子展示标识；  在CUPBOARD（取餐柜模式 场景：该标识为格子展示编号，商户可自行设置
        /// </summary>
        [XmlElement("carrier_sub_no")]
        public string CarrierSubNo { get; set; }
    }
}
