using System;

namespace Lap5
{
    public class AmountExeption : Exception
    {
        private string _personName;
        private string _message;

        public AmountExeption(string message, string personName) : base(message)
        {
            this._message = message;
            this._personName = personName;
            PrintError();
        }

        private void PrintError()
        {
            Console.WriteLine($"Error: {_message}, Name: {_personName}");
        }
    }
}