using KShoppingKartMock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KShoppingKartMock.ViewModels
{
    public class MobileListViewModel
    {
        public IEnumerable<Mobile> Mobiles;

        public string CurrentCategory;
    }

}
