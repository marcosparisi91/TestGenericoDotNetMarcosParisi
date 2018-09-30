using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.DAO;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        [Route("todos")]
        [HttpGet]
        public IHttpActionResult GetUsers()
        {
            try
            {
                UserDAO getUsuarios = new UserDAO();
                return this.Ok(new { usuarios = getUsuarios.GetUsuarios() });

            }
            catch (Exception ex)
            {
                return this.InternalServerError();
            }

        }

        [Route("delete/{id}")]
        [HttpDelete]
        public IHttpActionResult DeleteUser(int id)
        {
            try
            {
                UserDAO deleteUsuarios = new UserDAO();
                deleteUsuarios.DeleteUsuario(id);
                return this.Ok();

            }
            catch (Exception ex)
            {
                return this.InternalServerError();
            }

        }

        [Route("crear/{user}")]
        [HttpPut]
        public IHttpActionResult CreateUser([FromBody] User user)
        {
            try
            {
                UserDAO insertarUsuarios = new UserDAO();
                insertarUsuarios.CreateUser(user);
                return this.Ok();

            }
            catch (Exception ex)
            {
                return this.InternalServerError();
            }

        }

        [Route("modificar/{user}")]
        [HttpPost]
        public IHttpActionResult ModificarUser([FromBody] User user)
        {
            try
            {
                UserDAO modificarUsuario = new UserDAO();

                return this.Ok(new { usuario = modificarUsuario.UpdateUser(user) });

            }
            catch (Exception ex)
            {
                return this.InternalServerError();
            }

        }
    }
}
