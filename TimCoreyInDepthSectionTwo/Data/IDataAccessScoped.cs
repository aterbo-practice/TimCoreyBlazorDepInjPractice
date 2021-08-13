namespace TimCoreyInDepthSectionTwo.Data
{
    public interface IDataAccessScoped
    {
        int getDumbInt();
        string getDumbString();

        int getCounterValue();

        void addOneToCounter();

    }
}