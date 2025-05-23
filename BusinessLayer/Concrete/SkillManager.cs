﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;
        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public List<Skill> GetAll()
        {
            return _skillDal.Get();
        }

        public Skill GetById(int id)
        {
            return _skillDal.GetById(id);
        }

        public void TAdd(Skill t)
        {
            _skillDal.Add(t);
        }

        public void TDelete(int id)
        {
            _skillDal.DeleteById(id);
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
