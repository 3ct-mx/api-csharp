using System;
using Microsoft.AspNetCore.Mvc;
using api_rest.Model;

namespace api_rest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController
	{

        // Lista vacia
        public List<Usuario> lista = new List<Usuario>();

        public UsuarioController()
		{
            lista.Add(new Usuario("JSB123", "correo@3ct.mx", "SDFsdsdf@##$DDC"));
            lista.Add(new Usuario("RocioABC", "rocio@gmail.com", "SDFsddsfsdf$DDC"));

        }

        [HttpGet(Name = "GetUsuario")]
        public List<Usuario> dameLista()
        {
            return lista;
        }
	

	}
}

