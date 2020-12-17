using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingShop.Models
{
    public class Login
    {
        [Display(Name ="Tên Đăng Nhập")]
        [Required(ErrorMessage = "Bạn phải nhập tài khoản")]
        public string Username { set; get; }
        [Required(ErrorMessage ="Bạn phải nhập mật khẩu")]
        [Display(Name ="Mật khẩu")]
        public string Password { set; get; }
    }
}
