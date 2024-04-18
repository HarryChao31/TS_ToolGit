using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TS_Tool.Models;
using TS_Tool.Service.Repository;

namespace TS_Tool.Service.GetBetInfo
{
    public interface IGetBetInfoService
    {
        List<Betdetail> GetBetInfoData(string WebId, string RefNo);
    }

    public class GetBetInfoService : IGetBetInfoService
    {
        const int MIX_PARLAY = 40;
        private readonly IGetBetInfoRepository _getBetInfoRepo;
        private readonly IGetOSBetInfoByMixParlayBetRepository _getOSBetInfoByMixParlayBetRepo;
        private readonly IGetOSBetInfoBySingleBetRepository _getOSBetInfoBySingleBetRepo;

        public GetBetInfoService(
            IGetBetInfoRepository getBetInfoRepo,
            IGetOSBetInfoByMixParlayBetRepository getOSBetInfoByMixParlayBetRepo,
            IGetOSBetInfoBySingleBetRepository getOSBetInfoBySingleBetRepo)
        {
            _getBetInfoRepo = getBetInfoRepo;
            _getOSBetInfoByMixParlayBetRepo = getOSBetInfoByMixParlayBetRepo;
            _getOSBetInfoBySingleBetRepo = getOSBetInfoBySingleBetRepo;
        }

        public List<Betdetail> GetBetInfoData(string WebId, string RefNo)
        {
            var nsBetDetails = _getBetInfoRepo.GetBetInfoData(WebId, RefNo);
            List<Betdetail> combinedBetDetails = new List<Betdetail>();
            return _getBetInfoRepo.GetBetInfoData(WebId, RefNo);

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
        }

           // return combinedBetDetails;
        }
    }
//}
