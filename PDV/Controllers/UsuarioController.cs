﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PDV.DAL;

namespace PDV.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/
        [HttpGet]
        public JsonResult AutenticacaoDeUsuario(string Login, string Senha)
        {
            if (RepositorioUsuarios.AutenticarUsuario(Login, Senha))
            {
                return Json(new
                {
                    OK = true,
                    Mensagem = "Usuário autenticado. Redirecionando..."
                },
                    JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    OK = false,
                    Mensagem = "Usuário não encontrando. Tente novamente."
                },
                JsonRequestBehavior.AllowGet);
            }
        }
	}
}