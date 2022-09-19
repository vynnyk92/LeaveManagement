using FluentValidation;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Application.DTOs.Abstractions;

namespace LeaveManagement.Application.DTOs.Validators
{
    public class DtoWithLeaveTypeDtoValidator : AbstractValidator<IDtoWithLeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public DtoWithLeaveTypeDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            RuleFor(p => p.LeaveTypeId)
                .MustAsync(async (id, token) =>
                {
                    var leaveType = await _leaveTypeRepository.Get(id);
                    return leaveType != null;
                }).WithMessage("Wrong leaveType {PropertyName}");
        }
    }
}
