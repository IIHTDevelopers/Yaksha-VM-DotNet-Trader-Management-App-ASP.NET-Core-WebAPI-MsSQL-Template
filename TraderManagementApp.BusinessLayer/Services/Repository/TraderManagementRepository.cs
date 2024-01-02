using Microsoft.EntityFrameworkCore;
using TraderManagementApp.BusinessLayer.ViewModels;
using TraderManagementApp.DataLayer;
using TraderManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TraderManagementApp.BusinessLayer.Services.Repository
{
    public class TraderManagementRepository : ITraderManagementRepository
    {
        private readonly TraderManagementAppDbContext _dbContext;
        public TraderManagementRepository(TraderManagementAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Trader> CreateTrader(Trader TraderModel)
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