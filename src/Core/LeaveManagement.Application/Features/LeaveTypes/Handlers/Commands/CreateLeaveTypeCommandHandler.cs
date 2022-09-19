using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.Features.LeaveTypes.Requests;
using LeaveManagement.Application.Responses;
using LeaveManagement.Domain;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, BaseCommandResponse>
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

        public async Task<BaseCommandResponse> Handle(CreateLeaveTypeCommand command, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(command.LeaveTypeDto, cancellationToken);
            if (!validationResult.IsValid)
            {
                var messages = validationResult.Errors.Select(p=>p.ErrorMessage).ToList();
                return new BaseCommandResponse(null, false, $"Failed to create {nameof(LeaveType)}", messages);
            }

            var leaveTypeEntity = _mapper.Map<LeaveType>(command.LeaveTypeDto);
            leaveTypeEntity = await _leaveTypeRepository.Add(leaveTypeEntity);
            return new BaseCommandResponse(leaveTypeEntity.Id, true, $"Successfully created {nameof(LeaveType)}", new List<string>());
        }
    }
}
