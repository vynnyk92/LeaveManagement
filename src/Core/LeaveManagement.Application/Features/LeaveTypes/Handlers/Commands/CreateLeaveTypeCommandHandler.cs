using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.Features.LeaveTypes.Requests;
using LeaveManagement.Domain;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateLeaveTypeDto> _validator;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper, IValidator<CreateLeaveTypeDto> validator)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand command, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(command.LeaveTypeDto, cancellationToken);
            if (!validationResult.IsValid)
                throw new Exception();

            var leaveTypeEntity = _mapper.Map<LeaveType>(command.LeaveTypeDto);
            leaveTypeEntity = await _leaveTypeRepository.Add(leaveTypeEntity);
            return leaveTypeEntity.Id;
        }
    }
}
