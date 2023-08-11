class Course
{
    public string UniqueId { get; set; }
    public string Name { get; set; }
    public CourseTime Time { get; set; }
    public List<Subject> Subjects { get; set; }
    public List<Student> Students{ get; set; }

    public Course()
    {
        UniqueId = Guid.NewGuid().ToString();
    }
}