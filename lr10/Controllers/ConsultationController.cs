using Microsoft.AspNetCore.Mvc;
using lr10.Models;

public class ConsultationController : Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        ViewBag.Products = new List<string> { "JavaScript", "C#", "Java", "Python", "Основи" };
        return View();
    }

    [HttpPost]
    public IActionResult Register(ConsultationFormModel model)
    {
        if (model.Product == "Основи" && model.ConsultationDate.DayOfWeek == DayOfWeek.Monday)
        {
            ModelState.AddModelError("Product", "Консультація щодо продукту «Основи» не може проходити по понеділках.");
        }

        if (ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }

        ViewBag.Products = new List<string> { "JavaScript", "C#", "Java", "Python", "Основи" };
        return View(model);
    }

    [HttpGet]
    public IActionResult Success()
    {
        return View();
    }
}
