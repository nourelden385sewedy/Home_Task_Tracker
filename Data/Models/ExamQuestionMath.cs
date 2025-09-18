﻿using System;
using System.Collections.Generic;

namespace Task_Tracker_V4.Models;

public partial class ExamQuestionMath
{
    public string? Question { get; set; }

    public string? OptionA { get; set; }

    public string? OptionB { get; set; }

    public string? OptionC { get; set; }

    public string? OptionD { get; set; }

    public string? CorrectAnswer { get; set; }

    public string? CorrectAnswerTxt { get; set; }

    public int? SectionId { get; set; }
}
