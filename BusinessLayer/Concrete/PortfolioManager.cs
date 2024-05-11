using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;
        public PortfolioManager(IPortfolioDal portfolioDal) 
        {
            _portfolioDal = portfolioDal;
        }

        public List<Portfolio> GetAll()
        {
            return _portfolioDal.Get();
        }

        public Portfolio GetById(int id)
        {
            return _portfolioDal.GetById(id);
        }

        public void TAdd(Portfolio t)
        {
            _portfolioDal.Add(t);
        }

        public void TDelete(int id)
        {
            _portfolioDal.DeleteById(id);
        }

        public void TUpdate(Portfolio t)
        {
            _portfolioDal.Update(t);
        }
    }
}
