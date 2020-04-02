using System.Linq;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;//Controller ile CourseController farklı namespacelerde oldukları için eklemek gerekiyor


namespace CourseApp.Controllers{
    public class CourseController:Controller
    {
        //local:5000/course
            public IActionResult Index()
            {
                //local:5000/index
                return View();
            }
            public IActionResult List()
            {
                //local:5000/index
                var students = Repository.students.Where(i=>i.Confirm == true) ;


                return View(students);
            }
            [HttpGet]
            //Bize bir form getirdiği için tipi httpGet olmalı.Yani biz bir bilgi talep ediyoruz
            public IActionResult Apply(){
                return View();
            }

            //localhost:5000/course/apply method::POST
            [HttpPost]
            public IActionResult Apply(Student student){
                //Student student şeklinde paketleme işlemine model binding denir...yoksa string Name,string Email,string Phone,string Confirm şeklinde yazmamız gerekebilir
                if(ModelState.IsValid){ //Bütün validasyonları geçip geçmediği belirtilir
                    Repository.AddStudent(student);
                    return View("Thanks",student);
                }
                else{
                    return View(student);
                }
            }
            public IActionResult Details(){
                //buradaki bilgileri ileriki süreçte veri tabanından çekeceğiz
                var course = new Course();
                course.Name ="Core Mvc Course";
                course.Description ="Advanced Level";
                course.isPublished ="Released"; 
                return View(course);//paketlediğimiz veriyi viewe taşıyoruz
            }

    }
}