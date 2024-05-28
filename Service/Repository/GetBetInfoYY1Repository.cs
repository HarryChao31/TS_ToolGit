using TS_Tool.DataLayer;

namespace TS_Tool.Service.Repository
{
    public class GetBetInfoYY1Repository: GetBetInfoRepository<YY1GameProviderDbContext>
    {
        public GetBetInfoYY1Repository(YY1GameProviderDbContext dbContext) : base(dbContext) { }

    }
}
