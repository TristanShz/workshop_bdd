using System;
namespace snakegameworkshop
{
    public class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(string message) : base(message) { }
    }
}

