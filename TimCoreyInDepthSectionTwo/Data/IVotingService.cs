namespace TimCoreyInDepthSectionTwo.Data
{
    public interface IVotingService
    {
        int NoValue { get; }
        int YesValue { get; }

        void NoVote();
        void YesVote();
    }
}