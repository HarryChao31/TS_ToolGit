using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using TS_Tool.DataLayer;
using TS_Tool.Models;

namespace TS_Tool.Service.Repository
{
    public interface IGetSWErrorRepository<TContext>
    {
        List<SeamlessWalletError> GetSWErrorFromDB(int webId, string refNo);
    }

    public class GetSWErrorRepository<TContext> : IGetSWErrorRepository<TContext> where TContext : DbContext
    {
        private readonly TContext _dbContext;

        public GetSWErrorRepository(TContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<SeamlessWalletError> GetSWErrorFromDB(int WebId, string RefNo)
        {
            var SWError = _dbContext.Set<SeamlessWalletError>()
                .FromSqlRaw($"EXEC GetSeamlessWalletError {WebId}, '{RefNo}'")
                .AsNoTracking()
                .ToList();
            return SWError;
        }
    }
}
