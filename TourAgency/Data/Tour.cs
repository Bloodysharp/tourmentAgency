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
    
    public partial class Tour
    {
        public int id { get; set; }
        public int ticketCount { get; set; }
        public string tourName { get; set; }
        public string tourDescription { get; set; }
        public string imagePreview { get; set; }
        public decimal TourPrice { get; set; }
        public bool isActual { get; set; }
    
        public virtual HotelTour HotelTour { get; set; }
        public virtual TypeOfTour TypeOfTour { get; set; }
    }
}