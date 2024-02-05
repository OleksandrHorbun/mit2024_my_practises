using Microsoft.Identity.Client;

namespace Practice_1.Models
{
    public class Student
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public int Age { get; set; }

    }

    public class Grade
    {

        public int Id { get; set; }

        public string StudentId {  get; set; }

        public int SubjectID {  get; set; }

        public DateOnly Date {  get; set; }

    }

    public class Subject
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Teacher { get; set; }

    }

}
