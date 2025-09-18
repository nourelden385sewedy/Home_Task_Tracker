﻿using System;
using System.Collections.Generic;

namespace Task_Tracker_V4.Models;

public partial class SubordinateTicket
{
    public long Id { get; set; }

    public long? SupervisorAccountId { get; set; }

    public long? GradeId { get; set; }

    public long? ClassId { get; set; }

    public long? SessionId { get; set; }

    public long? SubordinateAccountId { get; set; }

    public long? TicketTypeId { get; set; }

    public long StatusId { get; set; }

    public virtual TblClass? Class { get; set; }

    public virtual Grade? Grade { get; set; }

    public virtual Session? Session { get; set; }

    public virtual Status Status { get; set; } = null!;

    public virtual Account? SubordinateAccount { get; set; }

    public virtual Account? SupervisorAccount { get; set; }

    public virtual TicketType? TicketType { get; set; }
}
