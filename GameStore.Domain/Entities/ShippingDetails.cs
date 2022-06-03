using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Укажите, как Вас зовут")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Укажите адрес доставки")]
        [Display(Name = "Улица")]
        public string Line1 { get; set; }
        [Display(Name = "Дом")]
        public string Line2 { get; set; }
        [Display(Name = "Квартира")]
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Укажите город")]
        [Display(Name = "Город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Укажите страну")]
        [Display(Name = "Страна")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
