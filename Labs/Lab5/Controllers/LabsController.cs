using System.Diagnostics;
using Lab5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using LabsLibrary2;

namespace Lab5.Controllers
{
    public class LabsController : Controller
    {
        //[Authorize]
        [HttpGet]
        public IActionResult Lab1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Lab1(IFormFile inputFile)
        {
            if (inputFile == null || inputFile.Length == 0)
            {
                ViewBag.Result = "Будь ласка, завантажте файл.";
                return View();
            }
            string inputFilePath = Path.Combine(Path.GetTempPath(), inputFile.FileName);
            using (var stream = new FileStream(inputFilePath, FileMode.Create))
            {
                inputFile.CopyTo(stream);
            }
            string outputFilePath = Path.Combine(Path.GetTempPath(), "output.txt");
            LabRunner labRunner = new LabRunner();
            labRunner.RunLab1(inputFilePath, outputFilePath);
            string result = System.IO.File.ReadAllText(outputFilePath);
            ViewBag.Result = result;

            return View();
        }

        //[Authorize]
        [HttpGet]
        public IActionResult Lab2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Lab2(IFormFile inputFile)
        {
            if (inputFile == null || inputFile.Length == 0)
            {
                ViewBag.Result = "Будь ласка, завантажте файл.";
                return View();
            }
            string inputFilePath = Path.Combine(Path.GetTempPath(), inputFile.FileName);
            using (var stream = new FileStream(inputFilePath, FileMode.Create))
            {
                inputFile.CopyTo(stream);
            }
            string outputFilePath = Path.Combine(Path.GetTempPath(), "output.txt");
            LabRunner labRunner = new LabRunner();
            labRunner.RunLab2(inputFilePath, outputFilePath);
            string result = System.IO.File.ReadAllText(outputFilePath);
            ViewBag.Result = result;

            return View();
        }

        //[Authorize]
        [HttpGet]
        public IActionResult Lab3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Lab3(IFormFile inputFile)
        {
            if (inputFile == null || inputFile.Length == 0)
            {
                ViewBag.Result = "Будь ласка, завантажте файл.";
                return View();
            }
            string inputFilePath = Path.Combine(Path.GetTempPath(), inputFile.FileName);
            using (var stream = new FileStream(inputFilePath, FileMode.Create))
            {
                inputFile.CopyTo(stream);
            }
            string outputFilePath = Path.Combine(Path.GetTempPath(), "output.txt");
            LabRunner labRunner = new LabRunner();
            labRunner.RunLab3(inputFilePath, outputFilePath);
            string result = System.IO.File.ReadAllText(outputFilePath);
            ViewBag.Result = result;

            return View();
        }
    }
}