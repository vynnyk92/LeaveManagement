using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Application.Features.LeaveRequests.Requests;
using LeaveManagement.Domain;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveRequests.Handlers.Commands
{
    public class ChangeLeaveRequestCommandHandler : IRequestHandler<ChangeLeaveRequestCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public ChangeLeaveRequestCommandHandler(IMapper mapper, ILeaveRequestRepository leaveRequestRepository)
        {
            _mapper = mapper;
            _leaveRequestRepository = leaveRequestRepository;
        }

        public async Task<Unit> Handle(ChangeLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetRequestDetails(request.LeaveRequest.Id);
            _mapper.Map(request.LeaveRequest, leaveRequest);
            await _leaveRequestRepository.Update(leaveRequest);
            return Unit.Value;
        }
    }
}
