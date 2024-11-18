using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage="Lütfen Oda numarasını yazınız")]  
        public string RoomNumber { get; set; }
       
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisini yazınız")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen Oda başlığını giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısınız giriniz")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısını giriniz")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen Oda acıklamasını giriniz")]
        public string Description { get; set; }
    }
}
