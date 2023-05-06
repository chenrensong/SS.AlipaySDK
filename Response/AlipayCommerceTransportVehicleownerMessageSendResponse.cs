using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerMessageSendResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerMessageSendResponse : AopResponse
    {
        /// <summary>
        /// 批量发送结果
        /// </summary>
        [XmlArray("send_result_list")]
        [XmlArrayItem("vehicle_msg_send_result_entity")]
        public List<VehicleMsgSendResultEntity> SendResultList { get; set; }
    }
}
