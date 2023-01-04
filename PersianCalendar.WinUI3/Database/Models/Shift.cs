namespace PersianCalendar.WinUI3.Database.Models;
public class Shift
{
    public int Id
    {
        get; set;
    }
    public string Name
    {
        get; set;
    }
    public string ShiftTitle
    {
        get; set;
    }
    public string StartDate
    {
        get; set;
    }
    public string EndDate
    {
        get; set;
    }
    public bool IsActive
    {
        get; set;
    }
    public bool IsHidden
    {
        get; set;
    }
    public int ShiftPatternId
    {
        get; set;
    }

    //public int BlogId
    //{
    //    get; set;
    //}
    //public string Url
    //{
    //    get; set;
    //}

    //public List<Post> Posts { get; } = new();
    //public int PostId
    //{
    //    get; set;
    //}
    //public string Title
    //{
    //    get; set;
    //}
    //public string Content
    //{
    //    get; set;
    //}

    //public int BlogId
    //{
    //    get; set;
    //}
    //public Blog Blog
    //{
    //    get; set;
    //}
}
