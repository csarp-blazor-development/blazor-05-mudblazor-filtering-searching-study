using Kreta.Shared.Enums;
using Kreta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2022,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2021,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Hunor",
                    LastName="Ugráló",
                    BirthsDay=new DateTime(2020,2,11),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Kati",
                    LastName="Késő",
                    BirthsDay=new DateTime(2019,2,11),
                    SchoolYear=12,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Kenéz",
                    LastName="Kísérletező",
                    BirthsDay=new DateTime(2017,2,11),
                    SchoolYear=14,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="szakképzés"
                }
            };

            // Students
            modelBuilder.Entity<Student>().HasData(students);
        }
    }
}
