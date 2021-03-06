//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string State { get; set; }
        public Nullable<System.DateTime> OrderTime { get; set; }
        public Nullable<System.DateTime> FinishTime { get; set; }
        public Nullable<System.DateTime> DeliverTIME { get; set; }
        public string Reciever { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string DiliverId { get; set; }
        public int CommodityID { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual Commodity Commodity { get; set; }
    }
}
