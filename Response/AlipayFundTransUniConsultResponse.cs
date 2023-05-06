using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundTransUniConsultResponse.
    /// </summary>
    public class AlipayFundTransUniConsultResponse : AopResponse
    {
        /// <summary>
        /// 咨询时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("consult_date")]
        public string ConsultDate { get; set; }

        /// <summary>
        /// 转账咨询结果。 SUCCESS（该笔转账咨询成功）：成功； FAIL：失败（咨询不通过）。 注意：转账咨询结果是否通过只代表基于当前入参数和时间的咨询结论，不能100%保证后续使用相同参数一定可以在转账接口处理成功。
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
