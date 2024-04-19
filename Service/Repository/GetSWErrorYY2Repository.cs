using TS_Tool.DataLayer;

namespace TS_Tool.Service.Repository
{
    public class GetSWErrorYY2Repository : GetSWErrorRepository<YY2RecordDbContext>
    {
        public GetSWErrorYY2Repository(YY2RecordDbContext dbContext) : base(dbContext) { }
    }
}
