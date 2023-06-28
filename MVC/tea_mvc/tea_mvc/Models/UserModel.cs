using Microsoft.AspNetCore.Mvc.Rendering;
using tea_mvc.Models;

namespace tea_mvc.Models
{
    public class UserModel
    {
        public TeaType SelectTeaType { get; set; }
    }

    public enum TeaType
    {
        Tea, Coffee, GreenTea, BlackTea
    }
}

