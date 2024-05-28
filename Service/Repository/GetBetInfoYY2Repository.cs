using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using TS_Tool.DataLayer;
using TS_Tool.Models;
namespace TS_Tool.Service.Repository
{

    public class GetBetInfoYY2Repository : GetBetInfoRepository<YY2GameProviderDbContext>
    {


        public GetBetInfoYY2Repository(YY2GameProviderDbContext dbContext) : base(dbContext) { } 
    }

}
