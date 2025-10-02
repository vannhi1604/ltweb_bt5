using System.ComponentModel.DataAnnotations;

namespace ltweb_bt5.Models
{
    public class User
    {
        public long id { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Username: toi thieu 5 ki tu, toi fda 10 ki tu")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nhap mat khau")]
        [StringLength(maximumLength: 100, MinimumLength = 6, ErrorMessage = "Mat khau toi thieu 6 ki tu")]
        public string Password { get; set; }
        [Required]
        public string ReenterPassword { get; set; }
        [Required(ErrorMessage = "Nhap tuoi...")]
        [Range(18, 60, ErrorMessage = "Tuoi trong khoang 18-60")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Ban chua nhap email")]
        [RegularExpression(@"[A-Za-z0-9.]+@[A-Za-z0-9]+\.[A-Za-z]{2, 4}", ErrorMessage = "Ban chua nhap dung dinh dang")]
        public string Email { get; set; }
    }
}
