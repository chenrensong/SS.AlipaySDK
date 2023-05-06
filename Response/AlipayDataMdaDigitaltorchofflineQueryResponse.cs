using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataMdaDigitaltorchofflineQueryResponse.
    /// </summary>
    public class AlipayDataMdaDigitaltorchofflineQueryResponse : AopResponse
    {
        /// <summary>
        /// 数字火炬手年龄分布
        /// </summary>
        [XmlElement("age_distribution")]
        public string AgeDistribution { get; set; }

        /// <summary>
        /// 数字火炬手国家分布
        /// </summary>
        [XmlElement("country_distribution")]
        public string CountryDistribution { get; set; }

        /// <summary>
        /// 亚运数字人形象
        /// </summary>
        [XmlElement("digital_images")]
        public string DigitalImages { get; set; }

        /// <summary>
        /// 争当数字火炬手月活人数
        /// </summary>
        [XmlElement("monthly_activity")]
        public long MonthlyActivity { get; set; }

        /// <summary>
        /// 数字火炬手总数
        /// </summary>
        [XmlElement("total_digital_torch_bearer")]
        public long TotalDigitalTorchBearer { get; set; }

        /// <summary>
        /// 争当数字火炬手总人数
        /// </summary>
        [XmlElement("total_participants")]
        public long TotalParticipants { get; set; }
    }
}
