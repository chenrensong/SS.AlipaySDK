using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceOperationBsEnrollsRecoverResponse.
    /// </summary>
    public class AlipayCommerceOperationBsEnrollsRecoverResponse : AopResponse
    {
        /// <summary>
        /// 恢复报名失败的参与者列表
        /// </summary>
        [XmlArray("failed_participants")]
        [XmlArrayItem("bs_participant_response_d_t_o")]
        public List<BsParticipantResponseDTO> FailedParticipants { get; set; }
    }
}
