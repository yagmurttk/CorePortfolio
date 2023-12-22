using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class // <T> entity değeri alıyoruz şartımız bu T nin bir classa ait bütün değerlerini alabilir anlamına gelir.
    {
        void Insert(T t); // T türünde t parametresi alıyoruz.
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetByID(int id); // T türünde GetbyId( yani ID göre getir) int türünde id alıyoruz dışarıdan.
    }
}
