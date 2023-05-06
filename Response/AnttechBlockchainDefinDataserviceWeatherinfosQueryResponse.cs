using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceWeatherinfosQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinDataserviceWeatherinfosQueryResponse : AopResponse
    {
        /// <summary>
        /// 气象信息
        /// </summary>
        [XmlArray("weather_infos")]
        [XmlArrayItem("weather_info")]
        public List<WeatherInfo> WeatherInfos { get; set; }
    }
}
