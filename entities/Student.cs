class Student
{
    public string UniqueId { get; private set; }
    public string Name { get; set; }
    public List<Exam> Exams { get; set; } = new List<Exam>();

    public Student()
    {
        UniqueId = Guid.NewGuid().ToString();
    }
}