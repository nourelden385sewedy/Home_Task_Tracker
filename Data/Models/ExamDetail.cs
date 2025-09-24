﻿using System;
using System.Collections.Generic;

namespace Task_Tracker_V4.Data.Models;

public partial class ExamDetail
{
    public long ExamId { get; set; }

    public string? Title { get; set; }

    public string? ExamSubject { get; set; }

    public string? ExamDescription { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Grade { get; set; }

    public string? Class { get; set; }
}
