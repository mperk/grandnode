﻿using FluentValidation.Attributes;
using Grand.Framework.Mvc.ModelBinding;
using Grand.Framework.Mvc.Models;
using Grand.Web.Areas.Admin.Validators.Courses;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Grand.Web.Areas.Admin.Models.Courses
{
    [Validator(typeof(CourseLessonValidator))]
    public partial class CourseLessonModel : BaseGrandEntityModel
    {
        public CourseLessonModel()
        {
            AvailableSubjects = new List<SelectListItem>();
        }

        [GrandResourceDisplayName("Admin.Courses.Course.Lesson.Fields.Name")]
        public string Name { get; set; }

        [GrandResourceDisplayName("Admin.Courses.Course.Lesson.Fields.Description")]
        public string Description { get; set; }

        [GrandResourceDisplayName("Admin.Courses.Course.Lesson.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public string CourseId { get; set; }

        [GrandResourceDisplayName("Admin.Courses.Course.Lesson.Fields.Subject")]
        public string SubjectId { get; set; }
        public IList<SelectListItem> AvailableSubjects { get; set; }

        [GrandResourceDisplayName("Admin.Courses.Course.Lesson.Fields.VideoFile")]
        [UIHint("Download")]
        public string VideoFile { get; set; }

        [GrandResourceDisplayName("Admin.Courses.Course.Lesson.Fields.Attachment")]
        [UIHint("Download")]
        public string AttachmentId { get; set; }

        [UIHint("Picture")]
        [GrandResourceDisplayName("Admin.Courses.Course.Lesson.Fields.PictureId")]
        public string PictureId { get; set; }

    }
}
