using System.Collections.Generic;
using AsratShowCase.Models;

namespace AsratShowCase.DAL
{
    public  interface IStateInfoRepository
	{
        IEnumerable<StateInfo> StatesInfo { get; }
	} 
}
