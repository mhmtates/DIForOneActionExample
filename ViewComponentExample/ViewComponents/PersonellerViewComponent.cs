using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentExample.Models;

namespace ViewComponentExample.ViewComponents
{
    public class PersonellerViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            
            List<Personel> data = new List<Personel> { 
            new Personel{Id=1,Name="Ahmet",Surname="Adıgüzel"},
            new Personel{Id=2,Name="Mehmet",Surname="Soyadıgüzel"},
            new Personel{Id=3,Name="Rıfkı",Surname="Bilmemneoglu"},
            new Personel{Id=4,Name="Rıfkı",Surname="Bilmemneoglu"},
            new Personel{Id=5,Name="Rıfkı",Surname="Bilmemneoglu"}
            };
            
            return View(data);
        }
    }
}
