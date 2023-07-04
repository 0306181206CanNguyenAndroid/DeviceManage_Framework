using DTO.ModelBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Model
{
    public class DecentralizationModel : DecentralizationModelBase
    {
        public string TeacherName { get; set; }
        public bool TeacherGender { get; set; }

        public string TeacherPhone { get; set; }
        public DateTime TeacherBirth {  get; set; }

        public string NameUser { get; set; }
        public DecentralizationModel() { }
    }
}
