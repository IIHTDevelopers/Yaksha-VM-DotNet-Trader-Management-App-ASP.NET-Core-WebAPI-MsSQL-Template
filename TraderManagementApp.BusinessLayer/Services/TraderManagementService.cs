using TraderManagementApp.BusinessLayer.Interfaces;
using TraderManagementApp.BusinessLayer.Services.Repository;
using TraderManagementApp.BusinessLayer.ViewModels;
using TraderManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TraderManagementApp.BusinessLayer.Services
{
    public class TraderManagementService : ITraderManagementService
    {
        private readonly ITraderManagementRepository _repo;

        public TraderManagementService(ITraderManagementRepository repo)
        {
            _repo = repo;
        }

        public async Task<Trader> CreateTrader(Trader employeeTrader)
        {
            //write your code here
            throw new NotFiniteNumberException();
        }

        public async Task<bool> DeleteTraderById(long id)
        {
            //write your code here
            throw new NotFiniteNumberException();
        }

        public List<Trader> GetAllTraders()
        {
            //write your code here
            throw new NotFiniteNumberException();
        }

        public async Task<Trader> GetTraderById(long id)
        {
            //write your code here
            throw new NotFiniteNumberException();
        }

        public async Task<Trader> UpdateTrader(TraderViewModel model)
        {
            //write your code here
            throw new NotFiniteNumberException();
        }
    }
}
