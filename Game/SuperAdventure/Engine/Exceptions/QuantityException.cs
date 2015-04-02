





namespace Engine.Exceptions
{
    using System;

    public class QuantityException : ApplicationException
    {
        //Creating the custom exception

        public QuantityException(string message, int minQuantity)
            :base (message)
        {
            this.MinQuantity = minQuantity;
        }

        public int MinQuantity { get; private set; }
    }
}
