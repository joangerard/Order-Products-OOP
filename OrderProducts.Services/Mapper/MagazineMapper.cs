using OrderProducts.Model;
using OrderProducts.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Services.Mapper
{
    public class MagazineMapper:IMapper<MagazineModel,PapersEntity>
    {
        public MagazineMapper()
        {

        }
        public MagazineModel Map(PapersEntity papersEntity)
        {
            MagazineModel magazineModel = new MagazineModel { MagazineId = papersEntity.BookId, Title = papersEntity.Title };
            switch (papersEntity.Type)
            {
                case 1:
                    magazineModel.Type = "Cientific";
                    break;
                case 2:
                    magazineModel.Type = "People";
                    break;
                case 3:
                    magazineModel.Type = "Nature";
                    break;
                case 4:
                    magazineModel.Type = "Motors";
                    break;
                default:
                    magazineModel.Type = "Other";
                    break;
            }
            return magazineModel;
        }

        public PapersEntity Map(MagazineModel magazineModel)
        {
            PapersEntity papersEntity = new PapersEntity { Title = magazineModel.Title, PaperType=PaperType.Magazine};
            switch (magazineModel.Type)
            {
                case "Cientific":
                    papersEntity.Type = 1;
                    break;
                case "People":
                    papersEntity.Type = 2;
                    break;
                case "Nature":
                    papersEntity.Type = 3;
                    break;
                case "Motors":
                    papersEntity.Type = 4;
                    break;
                case "Other":
                    papersEntity.Type = 5;
                    break;
            }
            return papersEntity;
        }
    }
}
