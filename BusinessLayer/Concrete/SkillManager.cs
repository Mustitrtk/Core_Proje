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
    public class SkillManager : IGenericService<Skill>
    {
        ISkillDal _skillDal;
        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public List<Skill> GetAll()
        {
            throw new NotImplementedException();
        }

        public Skill GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Skill t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
            throw new NotImplementedException();
        }
    }
}
