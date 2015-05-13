using AsratShowCase.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsratShowCase.DAL
{
    class DefaultConnectionRepostory : IStateInfoRepository 
    {
        private DefaultConnection context = new DefaultConnection();
        [Inject]
        public IEnumerable<StateInfo> StatesInfo
        {
            get { return context.StatesInfo.ToList(); }
        }
    }
}
