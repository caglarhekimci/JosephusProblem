namespace CaglarHekimci_JosephusProblem.Services
{
    public class FindLastPlayer : IFindLastPlayer
    {
        public string FindLastPlayerNumber(int bodyCount)
        {
            int lastPlayerNumber = 2 * (bodyCount - (int)Math.Pow(2, Math.Floor(Math.Log(bodyCount, 2)))) + 1;
            return $"The number of the last person standing in the group of {bodyCount} is  : {lastPlayerNumber}";
        }
    }
}
