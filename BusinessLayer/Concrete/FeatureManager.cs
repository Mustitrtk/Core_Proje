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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal) 
        {
            _featureDal = featureDal;
        }

        public List<Feature> GetAll()
        {
            return _featureDal.Get();
        }

        public Feature GetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public void TAdd(Feature t)
        {
            _featureDal.Add(t);
        }

        public void TDelete(int id)
        {
            _featureDal.DeleteById(id);
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}
