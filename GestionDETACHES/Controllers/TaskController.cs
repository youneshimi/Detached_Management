using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionDETACHES.Controllers
{
    public class TaskController : Controller
    {
        // Action Index pour afficher la liste des tâches
        public ActionResult Index()
        {
            // Données statiques (remplacez-les par vos propres données)
            var tasks = new List<string>
            {
                "Tâche 1",
                "Tâche 2",
                "Tâche 3"
            };

            return View(tasks);
        }

        // Action Details pour afficher les détails d'une tâche
        public ActionResult Details(int id)
        {
            // Données statiques (remplacez-les par vos propres données)
            var task = "Détails de la tâche " + id;

            return View(task);
        }

        public IActionResult Create()
        {
            return View("CreateTask"); // Assurez-vous que "CreateTask" est le nom de votre vue.
        }
    }


}
