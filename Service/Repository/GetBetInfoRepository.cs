using Microsoft.EntityFrameworkCore;
using TS_Tool.DataLayer;
using TS_Tool.Models;

namespace TS_Tool.Service.Repository
{
    public interface IGetBetInfoRepository {
        List<Betdetail> GetBetInfoData(String WebId, String RefNo);
    }
    public class GetBetInfoRepository : IGetBetInfoRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public GetBetInfoRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Betdetail> GetBetInfoData(String WebId, String RefNo)
        {
            var betdetailList = _dbContext.BetInformation
                .FromSqlRaw($"EXEC GetBetInfoByWebidAndRefno {WebId}, '{RefNo}'")
                .AsNoTracking()
                .ToList();

            return betdetailList;
        }
    }
}
