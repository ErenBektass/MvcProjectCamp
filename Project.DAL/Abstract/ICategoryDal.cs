using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Abstract
{
    public interface ICategoryDal
    {
        //CRUD
        //TYPE Name();
        List<Category> List();

        void Insert(Category p);
        void Update(Category p);
        void Delete(Category p);
    }
}
