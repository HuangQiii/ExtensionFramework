//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hub
{
    using System;
    using System.Collections.Generic;
    
    public partial class Token
    {
        public System.Guid TokenID { get; set; }
        public System.Guid UserID { get; set; }
        public string TokenCode { get; set; }
        public string CheckCode { get; set; }
        public System.DateTime Expire { get; set; }
        public int Status { get; set; }
    }
}
