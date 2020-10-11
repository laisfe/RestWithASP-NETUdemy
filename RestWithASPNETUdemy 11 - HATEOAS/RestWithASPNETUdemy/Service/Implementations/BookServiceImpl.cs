using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository.Generic;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Service.Implementations
{
    public class BookServiceImpl : IBookService
    {
        private readonly IRepository<Book> _repository;

        public BookServiceImpl(IRepository<Book> repository)
        {
            _repository = repository;
        }

        // Metodo responsável por criar uma nova pessoa
        // nesse momento adicionamos o objeto ao contexto
        // e finalmente salvamos as mudanças no contexto
        // na base de dados
        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        // Método responsável por retornar uma pessoa
        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }

        // Método responsável por retornar todas as pessoas
        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        // Método responsável por atualizar uma pessoa
        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

        // Método responsável por deletar
        // uma pessoa a partir de um ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
