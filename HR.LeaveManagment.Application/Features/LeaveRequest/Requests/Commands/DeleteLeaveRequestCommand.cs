﻿using HR.LeaveManagment.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Application.Features.LeaveRequest.Requests.Commands
{
    public class DeleteLeaveRequestCommand : IRequest
    {
        public int Id { get; set; }
    }
}
