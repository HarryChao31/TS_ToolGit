using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using TS_Tool.DataLayer;
using TS_Tool.Models;

namespace TS_Tool.Service.Repository
{
<<<<<<< HEAD
    public interface INewSystemGameProviderRepo {
        List<Betdetail> GetBetInfoData(String WebId, String RefNo);
        NewSystemSportsBet GetSportsBet(string webId, string refNo);
    }
    public class GetBetInfoRepository : INewSystemGameProviderRepo
=======
    public interface IGetBetInfoRepository<TContext> where TContext : DbContext
>>>>>>> 7c8d334497b69686fa991f7bd841d2857d8d8432
    {
        List<Betdetail> GetBetInfoData(int webId, string refNo);
    }

    public class GetBetInfoRepository<TContext> : IGetBetInfoRepository<TContext> where TContext : DbContext
    {
        private readonly TContext _dbContext;

        public GetBetInfoRepository(TContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Betdetail> GetBetInfoData(int webId, string refNo)
        {
            var betdetailList = _dbContext.Set<Betdetail>()
                .FromSqlRaw($"EXEC GetBetInfo {webId}, '{refNo}'")
                .AsNoTracking()
                .ToList();

            return betdetailList;
        }

        public NewSystemSportsBet GetSportsBet(string webId, string refNo)
        {
            throw new NotImplementedException();
        }
    }
}
