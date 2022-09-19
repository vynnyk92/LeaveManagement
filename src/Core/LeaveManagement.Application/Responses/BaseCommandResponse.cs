using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveManagement.Application.Responses
{
    public class BaseCommandResponse
    {
        public int? Id { get; set; }
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public IReadOnlyCollection<string> Errors { get; set; } = new List<string>();

        public BaseCommandResponse(int? id, bool isSuccess, string message, List<string> errors)
        {
            Id = id;
            IsSuccess = isSuccess;
            Message = message;
            Errors = errors;
        }
    }
}
