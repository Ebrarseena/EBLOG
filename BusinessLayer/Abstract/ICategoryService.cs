using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService //Metotlar tanımlanacak
    {
        void CategoryAdd(Category category); //Category sınıfından category parametresi alınır
        void CategoryRemove(Category category); 
        void CategoryUpdate(Category category); 

        List<Category> GetList(); // Listeyi getir

        Category GetById(int id); //İd'ye göre getir.
    }
}
