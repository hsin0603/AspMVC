using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Models
{
    public class Opera
    {
        [Display(Name = "編號")]
        public int OperaID { get; set; }

        [Required(ErrorMessage = "歌劇名稱不可以為空白")]
        [StringLength(200)]
        [Display(Name = "歌劇名稱")]      
        public string Title { get; set; }

        [Display(Name = "年代")]
        [CheckValidYear]
        public int? Year { get; set; }

        [Required]
        [Display(Name = "作者")]
        public string Composer { get; set; }

    }
}
