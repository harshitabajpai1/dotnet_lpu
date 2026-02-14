
using System;

namespace Domain
{
    public class PrimaryEntity : BaseEntity
    {
        public int PriorityOrKey { get; set; }

        public override void Validate()
        {
            // TODO: Add validation logic
            if(PriorityOrKey <= 0)
            {
                throw new ArgumentException("Priority or key can not be nagative");
            }
            
        }
    }
}
