﻿using System;
using System.Collections.Generic;

namespace Task_Tracker_V4.Models;

public partial class Grade
{
    public long Id { get; set; }

    public string GradeName { get; set; } = null!;

    public long? ParentGradeId { get; set; }

    public long? AdminAccountId { get; set; }

    public long StatusId { get; set; }

    public virtual Account? AdminAccount { get; set; }

    public virtual Status Status { get; set; } = null!;

    public virtual ICollection<SubordinateTicket> SubordinateTickets { get; set; } = new List<SubordinateTicket>();

    public virtual ICollection<TaskSubmission> TaskSubmissions { get; set; } = new List<TaskSubmission>();

    public virtual ICollection<TblClass> TblClasses { get; set; } = new List<TblClass>();

    public virtual ICollection<TblTask> TblTasks { get; set; } = new List<TblTask>();
}
