using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace dayLap06.Models
{
    public class Member
    {
        public string? MemberID { get; set; }
        [DisplayName("Tai khoan")]
        [Required(ErrorMessage ="tai khoan ko dc de trong")]
        [StringLength(20,MinimumLength = 3,ErrorMessage ="tai khoan co do dai trong khoang 3 - 20 ki tu")]
        public string MemberUserName { get; set; }

        [DisplayName("Mat khau")]
        [Required(ErrorMessage ="Mat khau ko dc de trong")]
        [StringLength(100 , MinimumLength = 8 , ErrorMessage ="mat khau toi thieu 8 ki tu")]

        public string Password { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage ="email ko dc de trong")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$",ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }


        [DisplayName("Dien thoai")]
        [Required(ErrorMessage ="So dien thoai ko dc bo trong")]
        [RegularExpression(@"^0\d{9}$",
        ErrorMessage = "Số điện thoại phải gồm 10 chữ số và bắt đầu bằng 0")]
        public string phone { get; set; }

        
    }
}