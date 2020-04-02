using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage = "İsminizi Giriniz")]
        public string Name { get; set; }     
        [Required (ErrorMessage = "Emailinizi Giriniz")] 
        [EmailAddress(ErrorMessage = "Mail Adresinizi Doğru Formatta Giriniz")]
        public string  Email { get; set; }
        [Required(ErrorMessage = "Telefon Numaranızı Giriniz")]
        public string Phone { get; set; }

        //true,false,null
        [Required(ErrorMessage = "Katılma Durumunuzu Belirtiniz")]
        public bool? Confirm { get; set; }//soru işareti eğer kullanıcı hiçbir şeyi seçmezse confirm değeri false olsun 
    }
}