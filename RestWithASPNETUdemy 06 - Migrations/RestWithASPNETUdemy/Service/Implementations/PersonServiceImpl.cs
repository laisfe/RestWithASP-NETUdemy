﻿using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Service.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        private readonly IPersonRepository _repository;

        public PersonServiceImpl(IPersonRepository repository)
        {
            _repository = repository;
        }

        // Metodo responsável por criar uma nova pessoa
        // nesse momento adicionamos o objeto ao contexto
        // e finalmente salvamos as mudanças no contexto
        // na base de dados
        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        // Método responsável por retornar uma pessoa
        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        // Método responsável por retornar todas as pessoas
        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        // Método responsável por atualizar uma pessoa
        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        // Método responsável por deletar
        // uma pessoa a partir de um ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
