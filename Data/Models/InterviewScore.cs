﻿using System;
using System.Collections.Generic;

namespace Task_Tracker_V4.Models;

public partial class InterviewScore
{
    public long Id { get; set; }

    public long AccountId { get; set; }

    public long InterviewerId { get; set; }

    public decimal Score { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Account Interviewer { get; set; } = null!;
}
