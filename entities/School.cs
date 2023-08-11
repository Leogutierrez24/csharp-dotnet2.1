class School
{
    public string UniqueId { get; private set; }

    private string _name = string.Empty;
    public string Name
    {
        get { return _name; }
        set { _name = value.ToUpper(); }
    }

    public int CreationYear { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public SchoolType SchoolType { get; set; }
    public List<Course> Courses { get; set; }

    public School(string name, int year)
    {
        _name = name;
        CreationYear = year;
    }

    public School(string name, int year, SchoolType schoolType, string country, string city)
    {
        _name = name;
        CreationYear = year;
        SchoolType = schoolType;
        Country = country;
        City = city;
    }

    public override string ToString()
    {
        return $"Name: {_name}, Type: {SchoolType}{Environment.NewLine}Country: {Country}, City: {City}";
    }
}