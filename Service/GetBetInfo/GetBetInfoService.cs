using Microsoft.EntityFrameworkCore;
using TS_Tool.DataLayer;
using TS_Tool.Models;
using TS_Tool.Service.Repository;

namespace TS_Tool.Service.GetBetInfo
{
    public interface IGetBetInfoService
    {
        List<Betdetail> GetBetInfoData(string Webid, string Refno);
    }
    public class GetBetInfoService : IGetBetInfoService
    {
        private readonly IGetBetInfoRepository _GetBetInfoRepo;

        public GetBetInfoService(IGetBetInfoRepository GetBetInfoRepo) {
            _GetBetInfoRepo = GetBetInfoRepo;
        }
        public List<Betdetail> GetBetInfoData(String WebId,String RefNo) => _GetBetInfoRepo.GetBetInfoData(WebId, RefNo);




    }
}
