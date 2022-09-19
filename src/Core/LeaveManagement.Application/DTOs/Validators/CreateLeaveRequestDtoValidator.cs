using System;
using FluentValidation;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Application.DTOs.LeaveRequest;

namespace LeaveManagement.Application.DTOs.Validators
{
    public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            Include(new DtoWithLeaveTypeDtoValidator(_leaveTypeRepository));
            RuleFor(r => r.StartDate)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(DateTime.Today);

            RuleFor(r => r.EndDate)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(r=> r.StartDate);

            RuleFor(r => r.RequestComments)
                .MaximumLength(200);
        }
    }
}
