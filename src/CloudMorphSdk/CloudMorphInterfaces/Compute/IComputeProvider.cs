namespace CloudMorphInterfaces.Compute
{
    public interface IComputeProvider
    {
        void LaunchInstance(string instanceId);
    }
}