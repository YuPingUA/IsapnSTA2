﻿using ISpanSTA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISpanSTA.ViewModel
{
    public class CStartExam2ViewModel
    {
        public List<TStudentFullInfo> student { get; set; }
        public List<TExaminationPaper> examp { get; set; }
        public List<TSuject> subject { get; set; }       
        public List<TRecord> record { get; set; }

    }
}