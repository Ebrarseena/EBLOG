using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal :IGenericDal<Category>
    {
        //List<Category> ListAllCategory(); //Entity değeri olarak üzerinde çalışılan Class verilir. Kategorinin tümünü getir
        //void AddCategory(Category category); //Kategori ekleme Parametre türü ve Parametre ismi
        //void DeleteCategory (Category category); //Kategori silme
        //void UpdateCategory (Category category); //Kategori güncelleme
        //Category GetById(int id); //Id'ye göre veri getirebilmek için tanımlanan metot
    }
}
