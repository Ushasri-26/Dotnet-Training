using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    //required, range, maxlength, minlength, regularexpression, phone, url, email, zip

    [Table("Studentstbl")] // now in sql server it create studentstbl
    public class Student
    {
        [Key] //Primary key
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // no idnetity
        [Required(ErrorMessage = "please enter the studentid")]
        
        [Column("Sid")]
        public int Studnetid { get; set; }
        
        [Required(ErrorMessage ="please enter the StudentName")]
        [RegularExpression("[a-zA-Z]+$", ErrorMessage = "Only alphabets are allowed")]
        [Column("Studentfullname", TypeName ="varchar")]
        [MaxLength(20)]
        public string StudentName { get; set; }
        public DateTime DOB {  get; set; }
        
        [Range(1,12, ErrorMessage = "Please enter the valid class")]
        [Required(ErrorMessage ="please enter the class")]
        public int Class { get; set; }

        [EmailAddress(ErrorMessage = "please enter the valid Email")]
        [Column("EmailAddress", TypeName = "varchar")]
        [MaxLength(50)]
        public string Email { get; set; }        
    }
}
