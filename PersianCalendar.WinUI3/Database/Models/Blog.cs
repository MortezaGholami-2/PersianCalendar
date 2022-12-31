using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace PersianCalendar.WinUI3.Database.Models;
public class Blog
{
    public int BlogId
    {
        get; set;
    }
    public string Url
    {
        get; set;
    }

    public List<Post> Posts { get; } = new();
}