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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal) 
        { 
            _messageDal = messageDal;
        }

        public List<Message> GetAll()
        {
            return _messageDal.Get();
        }

        public Message GetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public void TAdd(Message t)
        {
            _messageDal.Add(t);
        }

        public void TDelete(int id)
        {
            _messageDal.DeleteById(id);
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
