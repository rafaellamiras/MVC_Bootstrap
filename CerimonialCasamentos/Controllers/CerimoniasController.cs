namespace MVC_Bootstrap;
using CerimonialCasamentos.Models;
using Microsoft.AspNetCore.Mvc;
using MVC_Bootstrap.Models;

public class CerimoniasController : Controller
{
private static readonly List<Cerimonia> cerimonias = new();
private static int proximoId = 1;

public IActionResult Index()
    => View(cerimonias.OrderBy(c => c.Data).ToList());

public IActionResult Criar() => View();

[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Criar(Cerimonia cerimonia)
{
    if (!ModelState.IsValid) return View(cerimonia);

    cerimonia.Id = proximoId++;
    cerimonias.Add(cerimonia);
    TempData["Mensagem"] = "Cerimônia cadastrada com sucesso!";
    return RedirectToAction(nameof(Index));
}

[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Excluir(int id)
{
    var cerimonia = cerimonias.FirstOrDefault(c => c.Id == id);
    if (cerimonia is not null)
    {
        cerimonias.Remove(cerimonia);
        TempData["Mensagem"] = "Cerimônia removida.";
    }
    return RedirectToAction(nameof(Index));
}

}