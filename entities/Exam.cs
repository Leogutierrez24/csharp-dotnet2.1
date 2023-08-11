class Exam
{
    public string UniqueId { get; private set; }
    public string Name { get; set; }
    public Student Student { get; set; }
    public Subject Subject { get; set; }
    public float Grade { get; set; }

    public Exam()
    {
        UniqueId = Guid.NewGuid().ToString();
    }
}