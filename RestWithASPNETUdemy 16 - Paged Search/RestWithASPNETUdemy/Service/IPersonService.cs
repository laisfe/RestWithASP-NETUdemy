﻿using RestWithASPNETUdemy.Data.VO;
using System.Collections.Generic;
using Tapioca.HATEOAS.Utils;

namespace RestWithASPNETUdemy.Service
{
    public interface IPersonService
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        List<PersonVO> FindByName(string firstName, string lastName);
        PersonVO Update(PersonVO person);
        void Delete(long id);
        PagedSearchDTO<PersonVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page);

    }
}
