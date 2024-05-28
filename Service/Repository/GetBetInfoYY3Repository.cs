using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using TS_Tool.DataLayer;
using TS_Tool.Models;
namespace TS_Tool.Service.Repository
{

    public class GetBetInfoYY3Repository : GetBetInfoRepository<YY3GameProviderDbContext>
    {


        public GetBetInfoYY3Repository(YY3GameProviderDbContext dbContext) : base(dbContext) { }
    }

}
