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
        private readonly FirstDbContext _GameProviderdbContext;
        private readonly ILogger<GetBetInfoRepository> _logger;


        public GetBetInfoRepository(FirstDbContext GameProviderdbContext, ILogger<GetBetInfoRepository> logger)
        {
            _GameProviderdbContext = GameProviderdbContext;
            _logger = logger;
        }
        public List<Betdetail> GetBetInfoData(String WebId, String RefNo)
        {
            var betdetailList = _GameProviderdbContext.BetInformation
                .FromSqlRaw($"EXEC GetBetInfo {WebId}, '{RefNo}'")
                .AsNoTracking()
                .ToList();

            return betdetailList;
        }
    }
}
