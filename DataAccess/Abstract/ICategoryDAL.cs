using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.DataAccess.Abstract;

namespace DataAccess.Abstract
{
    public interface ICategoryDAL : IEntityRepository<Category>
    {
    }
}
