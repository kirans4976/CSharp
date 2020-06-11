using KShoppingKartMock.Data.Interfaces;
using KShoppingKartMock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KShoppingKartMock.Data.Mocks
{
    public class MockMobileRepository : IMobileRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Mobile> Mobiles
        {
            get
            {
                return new List<Mobile>
                {
                    new Mobile {
                        MobileName = "Poco f1",
                        Price = 7.95M, ShortDescription = "Mi",
                        LongDescription = "miui OS",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "http://imgh.us/beerL_2.jpg",
                        InStock = true,
                        IsPreferredMobile = true,
                        ImageThumbnailUrl = "~/Images/pocof1.jpeg"
                    },
                    new Mobile {
                        MobileName = "Honour",
                        Price = 12.95M, ShortDescription = "Honour",
                        LongDescription = "Honour 7x",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "http://imgh.us/rumCokeL.jpg",
                        InStock = true,
                        IsPreferredMobile = false,
                        ImageThumbnailUrl = "~/Images/honour.jpg"
                    },
                    new Mobile {
                        MobileName = "Apple ",
                        Price = 12.95M, ShortDescription = "APPLE",
                        LongDescription = "Honour 7s",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "http://imgh.us/tequilaL.jpg",
                        InStock = true,
                        IsPreferredMobile = false,
                        ImageThumbnailUrl = "~/Images/Iphone 7.jpg"
                    },
                    new Mobile
                    {
                        MobileName = "MI ",
                        Price = 12.95M,
                        ShortDescription = "MI",
                        LongDescription = "Mi A2",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "http://imgh.us/juiceL.jpg",
                        InStock = true,
                        IsPreferredMobile = false,
                        ImageThumbnailUrl = "~/Images/Mi A2"
                    }
                };
            }
        }
        public IEnumerable<Mobile> PerferredMobiles
        {
            get
            {
                return new List<Mobile>
                {
                    new Mobile {
                        MobileName = "Poco f1",
                        Price = 7.95M, ShortDescription = "Mi",
                        LongDescription = "miui OS",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "http://imgh.us/beerL_2.jpg",
                        InStock = true,
                        IsPreferredMobile = true,
                        ImageThumbnailUrl = "http://imgh.us/beerS_1.jpeg"
                    },
                    new Mobile
                    {
                        MobileName = "MI ",
                        Price = 12.95M,
                        ShortDescription = "MI",
                        LongDescription = "MI A2",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "http://imgh.us/juiceL.jpg",
                        InStock = true,
                        IsPreferredMobile = false,
                        ImageThumbnailUrl = "http://imgh.us/juiceS.jpg"
                    }
                };
            }
            //get; // it is viceversa brefore why?    
        }
        public Mobile GetMobileById(int MobileId)
        {
            throw new NotImplementedException();
        }
    }
}
