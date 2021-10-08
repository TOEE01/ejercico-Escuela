﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Dominio
{
    public enum Grade
    {
        A,B,C,D
    }

    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrollmentId { get; set; }

        public int CouserId { get; set; }

        public int StudentId { get; set; }

        public Grade? Grade { get; set; }

        public Course Course { get; set; }

        public Student Student { get; set; }

    }
}
