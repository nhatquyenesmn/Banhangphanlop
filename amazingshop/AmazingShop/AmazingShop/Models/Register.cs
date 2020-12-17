using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingShop.Models
{
    public class Register
    {
        [Key]
        public long ID { set; get; }
        [Display(Name ="Tên đăng nhập")]
        [Required(ErrorMessage ="Yêu cầu nhập tên đăng nhập")]
        public string Username { set; get; }
        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Yêu cầu nhập số điện thoại")]
        public string Phone { set; get; }
        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        [StringLength(20,MinimumLength =6 ,ErrorMessage ="Độ dài mật khẩu ít nhất 6 ký tự")]
        public string Password { set; get; }
        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("Password",ErrorMessage ="Xác nhận mật khẩu không đúng")]
        public string ConfirmPassword { set; get; }




    }
}
