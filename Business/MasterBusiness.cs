using System.Collections.Generic;
using retroBackend.Class;
using retroBackend.Data;
using retroBackend.Services;

namespace retroBackend.Business
{
    public class MasterBusiness
    {

        MasterService _masterService = new MasterService();
        public Task<List<Master>> GetMasterData(string param)
        {
            switch (param)
            {
                case "GetMaster":
                    var masterValue = GetMasterDataDetails();
                    return masterValue;
                default:
                    return null;
            }

        }


        private Task<List<Master>> GetMasterDataDetails()
        {

            return _masterService.GetMasterData();
        }
    }
}
