namespace ThreeTacos.CommonGlucoseMeter.Core.Entities;

public class CgmGlucoseValue
{
    public CgmGlucoseValue(int glucose, int trend, int timestamp)
    {
        Glucose = glucose;
        Trend = trend;
        Timestamp = timestamp;
    }

    public int Glucose { get; }
    public int Trend { get; }
    public int Timestamp { get; }
}