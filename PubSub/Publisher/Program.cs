using System;

namespace Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
			// This project should be responsible of published messages
			var inProgress = true;
			do
			{
				Console.WriteLine("Please enter message. Q to Quite");
				Console.Write("> ");
				string value = Console.ReadLine();
				if (value?.ToLower() != "q")
				{
					// Publish any message/object user will enter
				}
				else
				{
					inProgress = false;
				}
			} while (inProgress);
		}
    }
}
