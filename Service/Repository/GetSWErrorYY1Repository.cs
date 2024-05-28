using TS_Tool.DataLayer;

namespace TS_Tool.Service.Repository
{
    public class GetSWErrorYY1Repository:GetSWErrorRepository<YY1RecordDbContext>
    {
        public GetSWErrorYY1Repository(YY1RecordDbContext dbContext) : base(dbContext) { }

    }
}
