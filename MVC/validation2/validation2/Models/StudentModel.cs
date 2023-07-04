using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace validation2.Models
{ 
//{
//    [Bind(Exclude = "ID")]
    public class StudentModel
    {
       // [ScaffoldColumn(false)]
        public int Id { get; set; }

        //[Required(ErrorMessage = "Name is Required ")]
        //[StringLength(50, MinimumLength = 3)]

        public string Name { get; set; }


        //[Required(ErrorMessage = "Name is Required")]
        //[StringLength(50, MinimumLength = 3)]
    

        //[Required(ErrorMessage = "Email ID is Required ")]
        //[DataType(DataType.EmailAddress)]
        //[MaxLength(50)]
        //[RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}",ErrorMessage ="Incorrect Email Format")]
        public string Email { get; set; }

        //[Required(ErrorMessage ="Confirm Email is Required")]
        //[DataType(DataType.EmailAddress)]
        //[System.ComponentModel.DataAnnotations.Compare("Email",ErrorMessage ="Email Not Matched")]
        public string ConfirmEmail { get; set; }

        //[Required(ErrorMessage ="Age is Required ")]
        //[Range(1,100,ErrorMessage ="Age must be between 1-100 in year.")]
        public int Age { get; set; }
    }
}
