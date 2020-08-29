using Microsoft.AspNetCore.Mvc;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Controllers
{
    /* Mapeia as requisições de http://localhost:{porta}/api/person/
    Por padrão o ASP.NET Core mapeia todas as classes que extendem Controller
    pegando a primeira parte do nome da classe em lower case [Person]Controller
    e expõe como endpoint REST
    */
    [ApiVersion("1")]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        
        //Declaração do serviço usado
        //private readonly IBookService _bookService;

        /* Injeção de uma instancia de IPersonBusiness ao criar
        uma instancia de PersonController */
       /* public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        */

        //Mapeia as requisições GET para http://localhost:{porta}/api/person/
        //Get sem parâmetros para o FindAll --> Busca Todos
        // GET api/persons
        [HttpGet("v1")]
        public IActionResult Get()
        {
            //return Ok(_bookService.FindAll());
            return Ok();
        }

        //Mapeia as requisições GET para http://localhost:{porta}/api/person/{id}
        //recebendo um ID como no Path da requisição
        //Get com parâmetros para o FindById --> Busca Por ID
        // GET api/persons/5
        [HttpGet("v1/{id}")]
        public IActionResult Get(long id)
        {
            /*var book = _bookService.FindById(id);
            if (book == null) return NotFound();
            return Ok(book);*/
            return Ok();
        }

        //Mapeia as requisições POST para http://localhost:{porta}/api/person/
        //O [FromBody] consome o Objeto JSON enviado no corpo da requisição
        // POST api/persons
        [HttpPost("v1")]
        public IActionResult Post([FromBody]Book book)
        {
            /*if (book == null) return BadRequest();
            return new ObjectResult(_bookService.Create((book)));*/
            return Ok();
        }

        //Mapeia as requisições PUT para http://localhost:{porta}/api/person/
        //O [FromBody] consome o Objeto JSON enviado no corpo da requisição
        // PUT api/persons/5
        [HttpPut("v1")]
        public IActionResult Put([FromBody]Book book)
        {
            /*if (person == null) return BadRequest();
            var updatedPerson = _personService.Update(person);
            if (updatedPerson == null) return BadRequest();
            return new ObjectResult(updatedPerson);*/
            return Ok();
        }

        //Mapeia as requisições DELETE para http://localhost:{porta}/api/person/{id}
        //recebendo um ID como no Path da requisição
        // DELETE api/persons/5
        [HttpDelete("v1/{id}")]
        public IActionResult Delete(int id)
        {
            /*_bookService.Delete(id);
            return NoContent();*/
            return Ok();
        }
    }
}
