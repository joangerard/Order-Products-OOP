using OrderProducts.Repository.Config;
using OrderProducts.Repository.Entities;
using OrderProducts.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Repository.Repositories
{
    public class PapersRepositoryEF:IPapersRepository<PapersEntity>
    {

        public List<PapersEntity> GetAllByPaperType(int paperType)
        {
            List<PapersEntity> papersEntities = null;
            using (var dbContext = new StoreContext())
            {
                papersEntities = dbContext.Papers.Where(p => p.PaperType == paperType).ToList();
            }
            return papersEntities;
        }

        public int Create(PapersEntity paper)
        {
            int i = -1;
            using (var dbContext = new StoreContext())
            {
                dbContext.Papers.Add(paper);
                dbContext.SaveChanges();
                i = paper.BookId;
            }
            return i;
        }
    }
}
