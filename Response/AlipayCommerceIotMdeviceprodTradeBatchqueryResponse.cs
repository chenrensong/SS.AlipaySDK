using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodTradeBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodTradeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// iot交易设备信息列表
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("device_trade_response")]
        public List<DeviceTradeResponse> ResultList { get; set; }
    }
}
