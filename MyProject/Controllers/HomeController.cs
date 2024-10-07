using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using DxfLibrary;
using DxfLibrary.Entity;


namespace MyProject.Controllers;

public class HomeController : Controller
{
    public ActionResult CreateBlock()
    {
        // Yeni bir blok oluştur
        Block myBlock = new Block
        {
            Name = "MyBlock"
        };

        // Blok içine birkaç entity ekle
        myBlock.Entities.Add(new Line
        {
            StartX = 0,
            StartY = 0,
            EndX = 10,
            EndY = 10,
            Layer = "0",
            Color = "Red"
        });

        myBlock.Entities.Add(new Circle
        {
            CenterX = 5,
            CenterY = 5,
            Radius = 3,
            Layer = "0",
            Color = "Blue"
        });

        // İşlemleri gerçekleştirin (örneğin, veritabanına kaydetme veya dosyaya yazma)

        return View(myBlock); // Veya uygun bir ActionResult dönün
    }
}

