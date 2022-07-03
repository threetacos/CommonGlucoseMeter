using ThreeTacos.CommonGlucoseMeter.Core.Entities;

namespace ThreeTacos.CommonGlucoseMeter.Core.Contracts;

public interface ICgmGlucoseValueService
{
    Task<CgmGlucoseValue> GetLatestGlucoseValueAsync();
}