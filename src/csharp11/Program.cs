using csharp11;

class Program
{
    static void Main()
    {
        var requiredMembers = new RequiredMembers()
        {
            Id = 1,
            Name = "A",
            Description = "",
        };

        //Error
        //requiredMembers.Id = 2

        //Error
        //var requiredMembers2 = new RequiredMembers()
        //{
        //    Id = 1,
        //    Description = "A",
        //};

        _ = new ListPatterns();
    }
}