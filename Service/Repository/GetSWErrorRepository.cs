using Microsoft.EntityFrameworkCore;
using TS_Tool.DataLayer;
using TS_Tool.Models;

namespace TS_Tool.Service.Repository
{
    public interface IGetSWErrorRepository
    {
        List<SeamlessWalletError> GetSWErrorFromDB(string webId, string refNo);
    }
    public class GetSWErrorRepository : IGetSWErrorRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public GetSWErrorRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<SeamlessWalletError> GetSWErrorFromDB(String WebId, String RefNo) {
            var SWError = _dbContext.SWErrorInfo
  .FromSqlRaw($"EXEC GetSWErrorByWebidAndRefno {WebId}, '{RefNo}'")
  .AsNoTracking()
  .ToList();
            return SWError;
        }
    }
}
