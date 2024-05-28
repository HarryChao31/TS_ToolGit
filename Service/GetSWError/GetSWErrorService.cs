using Microsoft.EntityFrameworkCore;
using TS_Tool.DataLayer;
using TS_Tool.Models;
using TS_Tool.Service.Repository;

namespace TS_Tool.Service.GetSWError
{
    public interface IGetSWErrorService {
        List<SeamlessWalletError> GetSWErrorFromDB(int WebId, string RefNo);
    }
    public class GetSWErrorService : IGetSWErrorService
    {
        private readonly IGetSWErrorRepository<YY1RecordDbContext> _GetSWErrorRepo;
        private readonly IGetSWErrorRepository<YY2RecordDbContext> _GetSWErrorRepoYY2;
        public GetSWErrorService(IGetSWErrorRepository<YY1RecordDbContext> GetSWErrorRepo, IGetSWErrorRepository<YY2RecordDbContext> GetSWErrorRepoYY2)
        {
            _GetSWErrorRepo = GetSWErrorRepo;
            _GetSWErrorRepoYY2 = GetSWErrorRepoYY2;
        }
        public List<SeamlessWalletError> GetSWErrorFromDB(int WebId, string RefNo)
        {
            if (WebId < 1300)
            {
                return _GetSWErrorRepo.GetSWErrorFromDB(WebId, RefNo);
            }
            else if (WebId > 10000 & WebId < 20000)
            {
                return _GetSWErrorRepoYY2.GetSWErrorFromDB(WebId, RefNo);
            }
            else
            {
                // 如果 WebId 不匹配任何已知条件，则抛出异常或返回空列表等处理
                throw new ArgumentException("Invalid WebId");
            }
        }
    }
}
