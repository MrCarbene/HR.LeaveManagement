using HR.LeaveManagement.Application.Dtos.Common;

namespace HR.LeaveManagement.Application.LeaveType.Dtos
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}