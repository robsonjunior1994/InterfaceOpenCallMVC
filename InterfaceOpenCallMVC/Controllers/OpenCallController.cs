using InterfaceOpenCallMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace InterfaceOpenCallMVC.Controllers
{
    public class OpenCallController : Controller
    {
        HttpClient cliente = new HttpClient();
        public OpenCallController()
        {
            cliente.BaseAddress = new Uri("https://localhost:44379/");
            cliente.DefaultRequestHeaders.Accept.Clear();
            //cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<IActionResult> IndexAsync()
        {
            var userKey = "55963adf554043cd6422d861167688f6";

            cliente.DefaultRequestHeaders.Add("userKey", userKey);
            HttpResponseMessage resposta = await cliente.GetAsync("api/chamado?status=blala");

            var listaDeChamado = resposta.Content.ReadFromJsonAsync<List<ChamadoViewModel>>().Result;

            return View(listaDeChamado);
        }

        public IActionResult Login(UsuarioViewModel usuarioView = null)
        {
            if (usuarioView.Email != null || usuarioView.Senha != null)
            {
                //PEGAR EMAIL E SENHA E REQUISITAR A API DE LOGIN 
                return RedirectToAction("Index");
            }

            return View();
            
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            return View();
        }


    }
}
