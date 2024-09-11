using System; 
using System.Globalization;

namespace Rooms
{
	public class Student
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public int Room { get; set; }

        public override string ToString()
        {
            return Name + ", " + Email; 
        }
    }
}

