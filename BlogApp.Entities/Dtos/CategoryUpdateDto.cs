using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
   public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Kategori Adı : ")]//ne yazmasını istiyorsak onu yazıyoruz
        [Required(ErrorMessage = "{0} boş geçilemez")]
        [MaxLength(70, ErrorMessage = "{0} en fazla {1} karakter olabilir")]   //dinamik yaptık
        [MinLength(3, ErrorMessage = "{0} en az {1} karkter olmalıdır")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması : ")]
        [MaxLength(500, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karkter olmalıdır")]
        public string Description { get; set; }
        [DisplayName("Kategori Özel Not Alanı : ")]
        [MaxLength(500, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karkter olmalıdır")]
        public string Note { get; set; }
        [DisplayName("Aktif Mi? : ")]//ne yazmasını istiyorsak onu yazıyoruz
        [Required(ErrorMessage = "{0} boş geçilemez")]
        public bool IsActive { get; set; }
        [DisplayName("Silindi Mi? : ")]//ne yazmasını istiyorsak onu yazıyoruz
        [Required(ErrorMessage = "{0} boş geçilemez")]
        public bool IsDeleted { get; set; }
    }
}
