﻿using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interafaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses(); 
    }
}
