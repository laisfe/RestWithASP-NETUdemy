using RestWithASPNETUdemy.Data.Converters;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository.Generic;
using System.Collections.Generic;
using Tapioca.HATEOAS.Utils;

namespace RestWithASPNETUdemy.Service.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        private readonly IPersonRepository _repository;
        private readonly PersonConverter _converter;

        public PersonServiceImpl(IPersonRepository repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        // Metodo responsável por criar uma nova pessoa
        // nesse momento adicionamos o objeto ao contexto
        // e finalmente salvamos as mudanças no contexto
        // na base de dados
        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        // Método responsável por retornar uma pessoa
        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        // Método responsável por retornar todas as pessoas
        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        // Método responsável por retornar todas as pessoas
        public List<PersonVO> FindByName(string firstName, string lastName)
        {
            return _converter.ParseList(_repository.FindByName(firstName, lastName));
        }

        // Método responsável por atualizar uma pessoa
        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        // Método responsável por deletar
        // uma pessoa a partir de um ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public PagedSearchDTO<PersonVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page)
        {
            page = page > 0 ? page - 1 : 0;

            string query = @"select * from Persons p where 1 = 1 ";
            if (!string.IsNullOrEmpty(name)) query += $" and p.firstName like '%{name}%'";

            query += $" order by p.firstName {sortDirection} limit {pageSize} offset {page}";

            string countQuery = @"select count(*) from Persons p where 1 = 1 ";
            if (!string.IsNullOrEmpty(name)) countQuery = countQuery + $" and p.firstName like '%{name}%'";

            var persons = _repository.FindWithPagedSearch(query);

            int totalResults = _repository.GetCount(countQuery);

            return new PagedSearchDTO<PersonVO>
            {
                CurrentPage = page + 1,
                List = _converter.ParseList(persons),
                PageSize = pageSize,
                SortDirections = sortDirection,
                TotalResults = totalResults
            };
        }

        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }
    }
}
