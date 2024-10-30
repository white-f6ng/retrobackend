using System.Collections.Generic;
using retroBackend.Data;
using retroBackend.Class;

namespace retroBackend.Services
{
    public class MasterService
    {

        MasterRepository _masterRepository = new MasterRepository();
        public Task<List<Master>> GetMasterData()
        {
            return _masterRepository.GetMockData();
        }
    }
}
