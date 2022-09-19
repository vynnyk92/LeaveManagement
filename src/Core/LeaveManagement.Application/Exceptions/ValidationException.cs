using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeaveManagement.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();

        public ValidationException()
        {
            
        }
        public ValidationException(IReadOnlyCollection<string> errors)
        {
            Errors = errors.ToList();
        }
    }
}
