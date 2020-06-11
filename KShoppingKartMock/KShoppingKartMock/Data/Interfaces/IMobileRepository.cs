using KShoppingKartMock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KShoppingKartMock.Data.Interfaces
{

    public interface IMobileRepository
    {
        IEnumerable<Mobile> Mobiles { get; }
        IEnumerable<Mobile> PerferredMobiles { get; }
        Mobile GetMobileById(int mobileId);
    }
}
