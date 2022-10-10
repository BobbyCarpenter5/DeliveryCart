using System;

namespace Name.Services
{
    public class NameService
    {
        public bool IsName(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }
    }
}