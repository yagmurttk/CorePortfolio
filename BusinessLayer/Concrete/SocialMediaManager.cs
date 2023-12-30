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
    public class SocialMediaManager:ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TAdd(SocialMedia t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SocialMedia t)
        {
            throw new NotImplementedException();
        }

        public SocialMedia TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SocialMedia> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SocialMedia t)
        {
            throw new NotImplementedException();
        }
    }
}
