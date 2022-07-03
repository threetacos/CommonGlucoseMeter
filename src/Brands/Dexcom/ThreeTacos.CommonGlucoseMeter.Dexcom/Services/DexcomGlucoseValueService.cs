using ThreeTacos.CommonGlucoseMeter.Core.Contracts;
using ThreeTacos.CommonGlucoseMeter.Core.Entities;

namespace ThreeTacos.CommonGlucoseMeter.Dexcom.Services;

public class DexcomGlucoseValueService : ICgmGlucoseValueService
{
    public Task<CgmGlucoseValue> GetLatestGlucoseValueAsync()
    {
        throw new NotImplementedException();
    }
}