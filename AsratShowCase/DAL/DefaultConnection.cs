using System.Data.Entity;
using AsratShowCase.Models;

namespace AsratShowCase.DAL
{
    class DefaultConnection : DbContext
    {
        public DbSet<StateInfo> StatesInfo { get; set; }
    }
}
