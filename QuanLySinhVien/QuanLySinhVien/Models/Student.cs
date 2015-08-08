using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySinhVien.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Họ, Tên Đệm")]
        public string FirstName { get; set; }
        [Display(Name = "Tên")]
        public string LastName { get; set; }
        [Display(Name = "Ngày Nhập Học")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollment { get; set; }

    }
}