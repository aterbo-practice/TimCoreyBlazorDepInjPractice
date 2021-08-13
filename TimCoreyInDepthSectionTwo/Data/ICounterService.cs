namespace TimCoreyInDepthSectionTwo.Data
{
    public interface ICounterService
    {
        int CounterValue { get; }

        void IncreaseCounter();
    }
}