using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceSportsCheerResultConfirmResponse.
    /// </summary>
    public class AlipayCommerceSportsCheerResultConfirmResponse : AopResponse
    {
        /// <summary>
        /// 用户流水号
        /// </summary>
        [XmlElement("game_serial_number")]
        public string GameSerialNumber { get; set; }
    }
}
