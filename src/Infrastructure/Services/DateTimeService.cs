using Sanoma.Application.Common.Interfaces;
using System;

namespace Sanoma.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
