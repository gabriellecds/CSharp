using System;
namespace Students.Entities
{
	class StudentRecord
	{
		public int Code { get; set; }
       
        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is StudentRecord))
            {
                return false; 
            }

            StudentRecord other = obj as StudentRecord;
            return Code.Equals(other.Code); 
        }
    }
}

