using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;
using Keepr.Repositories;

namespace Keepr.Services
{
    public class KeepService
    {
        private readonly KeepRepository _repo;
        public KeepService(KeepRepository repo)
        {
            _repo = repo;
        }
        public IEnumerable<Keep> Get()
        {
            return _repo.Get();
        }

        public Keep Create(Keep newKeep)
        {
            _repo.Create(newKeep);
            return newKeep;
        }
    }
}