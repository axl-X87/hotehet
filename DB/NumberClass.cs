//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hotehet.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class NumberClass
    {
        public NumberClass()
        {
            this.Number = new HashSet<Number>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<Number> Number { get; set; }
    }
}
