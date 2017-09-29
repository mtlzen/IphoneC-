using System;
namespace IphoneCSharp.Models
{
    public class IphoneModel
    {
         
            public int SUBSIDY_SEQ_NO { get; set; }
            public DateTime SYS_CREATION_DATE { get; set; }
            public DateTime SYS_UPDATE_DATE { get; set; }
            public int OPERATOR_ID { get; set; }
            public string APPLICATION_ID { get; set; }
            public int DL_SERVICE_CODE { get; set; }
            public int DL_UPDATE_STAMP { get; set; }
            public string SKU { get; set; }
            public DateTime EFFECTIVE_DATE { get; set; }
            public string PROVINCE { get; set; }
            public int TERM { get; set; }
            public int ACTIVITY { get; set; }
            public string MIN_MSF { get; set; }
            public decimal PRICE { get; set; }
            public string HUP_TIER { get; set; }
            public int ADMIN_FEE { get; set; }
            public int SHARING_TYPE { get; set; }
    }
}
