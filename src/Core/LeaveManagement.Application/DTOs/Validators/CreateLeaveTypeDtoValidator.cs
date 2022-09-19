using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace LeaveManagement.Application.DTOs.Validators
{
    public class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(50);

            RuleFor(p => p.DefaultDays)
                .GreaterThan(0)
                .LessThan(50);
        }
    }
}
