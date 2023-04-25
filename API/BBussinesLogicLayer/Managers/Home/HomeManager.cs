using AutoMapper;
using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Repos;
using CDataAccessLayer.Repos.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Managers.Home
{
    public class HomeManager:IHomeManager
    {
        private readonly IHomeRepo _homeRepo;

        public HomeManager(IHomeRepo homeRepo)
        {
            _homeRepo = homeRepo;
        }
        public ICollection<string> GetAllSpecializations()
        {
            return _homeRepo.GetAllSpecializations();
        }

    }
}
