using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManager.Entities;

namespace GymManager.Repositories
{
    // Review IP: interface should be names ad IViewRepository, then the concrete implementation (on sql) will be named SqlViewRepository
    interface ISqlViewRepository
    {
        List<View> SelectView();
    }
}
