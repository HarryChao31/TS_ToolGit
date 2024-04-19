using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using TS_Tool.DataLayer;
using TS_Tool.Models;

namespace TS_Tool.Service.Repository
{
    public interface IGetBetInfoRepository<TContext> where TContext : DbContext
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
    }
}
