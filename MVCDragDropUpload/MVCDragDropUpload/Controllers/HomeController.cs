using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace MVCDragDropUpload.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EnviarArquivos(IEnumerable<HttpPostedFileBase> files)
        {
            //verifica os arquivos enviados
            foreach (var file in files)
            {
                //atribui um novo nome.
                string filePath = Guid.NewGuid() + Path.GetExtension(file.FileName);

                //salva dentro da mesma pasta dentro do projeto
                file.SaveAs(Path.Combine(Server.MapPath("~/UploadedFiles"), filePath));
            }

            //retorna a mensagem via JSon
            return Json("arquivo enviado com sucesso.");
        }
    }
}