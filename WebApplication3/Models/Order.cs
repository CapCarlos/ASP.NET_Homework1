using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Order
    {
        /// <summary>
        /// 訂單編號
        /// </summary>


        public int OrderId { get; set; }



        /// <summary>
        /// 客戶名稱
        /// </summary>

        public string CustName { get; set; }



        /// <summary>
        /// 業務(員工姓名)
        /// </summary>
        /// 

        public string EmpName { get; set; }



        /// <summary>
        /// 出貨公司名稱
        /// </summary>
        /// 

        public string ShipperName { get; set; }


        /// <summary>
        /// 訂單日期
        /// </summary>
        /// 

        public DateTime? Orderdate { get; set; }



        /// <summary>
        /// 出貨日期
        /// </summary>
        /// 

        public DateTime? ShippedDate { get; set; }


        /// <summary>
        /// 需要日期
        /// </summary>
        /// 

        public DateTime? RequireDdate { get; set; }


    }
}