using System;

namespace DataLayer.EfClasses;

public class Event
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public DateTime BeginsAt { get; set; }
    public DateTime EndsAt { get; set; }
    public string Description { get; set; }
    public DateTime InsertedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}