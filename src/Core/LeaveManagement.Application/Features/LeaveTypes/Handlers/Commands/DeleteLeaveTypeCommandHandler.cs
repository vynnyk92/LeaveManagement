using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Application.Features.LeaveTypes.Requests;
using LeaveManagement.Domain;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeRequest>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveTypeRequest command, CancellationToken cancellationToken)
        {
            var leaveTypeEntity = await _leaveTypeRepository.Get(command.Id);
            await _leaveTypeRepository.Delete(leaveTypeEntity);
            return Unit.Value;
        }
    }
}
