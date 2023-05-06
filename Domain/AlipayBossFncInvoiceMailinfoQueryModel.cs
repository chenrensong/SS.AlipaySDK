using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayBossFncInvoiceMailinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoiceMailinfoQueryModel : AopObject
    {
        /// <summary>
        /// 邮寄ID，唯一性ID，邮寄信息表唯一主键ID
        /// </summary>
        [XmlElement("mail_id")]
        public string MailId { get; set; }
    }
}
