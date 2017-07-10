using OrderProducts.Model;
using OrderProducts.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Services.Mapper
{
    public class NewspaperMapper:IMapper<NewspaperModel,PapersEntity>
    {
        public NewspaperModel Map(PapersEntity papersEntity)
        {
            NewspaperModel newspaperModel = new NewspaperModel
            {
                NewspaperId = papersEntity.BookId,
                PublicationDate = papersEntity.PublicationDate,
                Title = papersEntity.Title
            };
            return newspaperModel;
        }

        public PapersEntity Map(NewspaperModel newspaper)
        {
            PapersEntity papersEntity = new PapersEntity
            {
                PublicationDate = newspaper.PublicationDate,
                Title = newspaper.Title,
                PaperType = PaperType.Newspaper
            };
            return papersEntity;
        }
    }
}
