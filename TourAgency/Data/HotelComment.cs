//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TourAgency.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class HotelComment
    {
        public int id { get; set; }
        public int idHotel { get; set; }
        public string commentText { get; set; }
        public string commentAuthor { get; set; }
        public System.DateTime commentCreationTime { get; set; }
    
        public virtual Hotel Hotel { get; set; }
    }
}