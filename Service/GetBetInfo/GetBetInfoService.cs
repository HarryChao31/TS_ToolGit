using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TS_Tool.DataLayer;
using TS_Tool.Models;
using TS_Tool.Service.Repository;

namespace TS_Tool.Service.GetBetInfo
{
    public interface IGetBetInfoService
    {
        List<Betdetail> GetBetInfoData(int WebId, string RefNo);
    }

    public class GetBetInfoService : IGetBetInfoService
    {
        const int MIX_PARLAY = 40;
        private readonly IGetBetInfoRepository<YY1GameProviderDbContext> _getBetInfoRepo;
        private readonly IGetBetInfoRepository<YY2GameProviderDbContext> _getBetInfoRepoYY2;

        public GetBetInfoService(
            IGetBetInfoRepository<YY1GameProviderDbContext> getBetInfoRepo,
            IGetBetInfoRepository<YY2GameProviderDbContext> getBetInfoRepoYY2)
        {
            _getBetInfoRepo = getBetInfoRepo;
            _getBetInfoRepoYY2 = getBetInfoRepoYY2;
        }

        public List<Betdetail> GetBetInfoData(int WebId, string RefNo) {
            if (WebId < 1300) {
                return _getBetInfoRepo.GetBetInfoData(WebId, RefNo);
            }
            else if (WebId >10000 & WebId < 20000)
            {
                return _getBetInfoRepoYY2.GetBetInfoData(WebId, RefNo);
            }
            else
            {
                // 如果 WebId 不匹配任何已知条件，则抛出异常或返回空列表等处理
                throw new ArgumentException("Invalid WebId");
            }
        }
        
        //=> _getBetInfoRepo.GetBetInfoData(WebId, RefNo);
        //public List<Betdetail> GetBetInfoData(string WebId, string RefNo)
        //{

            //var nsBetDetails = _getBetInfoRepo.GetBetInfoData(WebId, RefNo);
            //List<Betdetail> combinedBetDetails = new List<Betdetail>();
            //foreach (var nsBetDetail in nsBetDetails)
            //{
            //    List<Betdetail> osBetDetails;

            //    if (nsBetDetail.BetType == MIX_PARLAY)
            //    {
            //        osBetDetails = _getOSBetInfoByMixParlayBetRepo.GetOSBetInfoDataByMixParlay(WebId, RefNo);
            //    }
            //    else
            //    {
            //        osBetDetails = _getOSBetInfoBySingleBetRepo.GetOSBetInfoDataBySingleBet(WebId, RefNo);
            //    }

            //    // 合并 NsBetDetail 和 OsBetDetails
            //    foreach (var osBetDetail in osBetDetails)
            //    {
            //        Betdetail fullBetDetail = new Betdetail
            //        {
            //            // 将必要的属性复制到 fullBetDetail
            //            OsStatus = osBetDetail.OsStatus,
            //            MatchResultId = osBetDetail.MatchResultId,
            //            Remark = osBetDetail.Remark
            //        };

            //        combinedBetDetails.Add(fullBetDetail);
            //    }
            //}

            //return combinedBetDetails;
        //}
    }
    
}
