using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// PointPrizeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PointPrizeInfo : AopObject
    {
        /// <summary>
        /// 奖品兑换的结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 兑换奖品所需的积分数，大于0
        /// </summary>
        [XmlElement("exchange_point")]
        public long ExchangePoint { get; set; }

        /// <summary>
        /// 奖品的发放使用规则说明等
        /// </summary>
        [XmlElement("intro")]
        public string Intro { get; set; }

        /// <summary>
        /// 奖品图片地址
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 积分奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品编号
        /// </summary>
        [XmlElement("prize_no")]
        public string PrizeNo { get; set; }

        /// <summary>
        /// 奖品类型。CONSUME_VOUCHER：消费红包，IN_KIND_PRIZE：实物奖品。全部类型可在财富开放平台查看
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 奖品开始兑换的时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 奖品库存，当前剩余可兑换的库存
        /// </summary>
        [XmlElement("stock")]
        public long Stock { get; set; }
    }
}
