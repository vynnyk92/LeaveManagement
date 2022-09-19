using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace LeaveManagement.Application.DTOs.Validators
{
    public class CreateLeaveAllocationDtoValidator : AbstractValidator<CreateLeaveAllocationDto>
    {
        public CreateLeaveAllocationDtoValidator()
        {
            
        }
    }
}
