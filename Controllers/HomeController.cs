using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers{

    //local:5000
    //local:5000/home
    public class HomeController:Controller
    {
        
/*
        //local:5000/home/index
        public string Index(){
            return "home/index";
        }

        //local:5000/home/about
        public string About(){
            return "home/about";
        }



 */       

 //büyük projelerde home sayfası çok büyük olduğu için tek satırlık bir şet dönmeyecek o yüzden bir html 
 //sayfasına ihtiyacımız var. ve html sayfasına erimek için View oluşturuyoruz yani .cshtml sayfasını barındırıyor
 //ve controllerdan View metodu ile çağiriyoruz
        public IActionResult Index(){
            //return "home/index";
            //dinamik html sayfasına razor denir.//diğer web programlama yapılarında ise tempate engine deniyor 

            int saat = DateTime.Now.Hour;

    
            ViewBag.Greeting = saat>10 ? "İyi Günler" : "Günaydın";
            ViewBag.UserName = "Osman Hocam";
            //Bir sonraki aşamada Viewbaglerle bilgiyi taımaktansa model dediğimiz yapıyı kullanacağız

            // Bu Bilgileri ViewBag Üzerinden erişilebilir hale getirmemiz gerekiyor
            return View();//dinamik bir html sayfası döndürür

        }

        //local:5000/home/about
        public IActionResult About(){
            return View();
        }
    }
}