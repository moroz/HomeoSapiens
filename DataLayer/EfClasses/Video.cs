using System;

namespace DataLayer.EfClasses;

public class Video
{
    public Guid Id { get; set; }
    public string YoutubeId { get; set; }
    public string Slug { get; set; }
    public string NamePl { get; set; }
    public string NameEn { get; set; }
    public string DescriptionPl { get; set; }
    public string DescriptionEn { get; set; }
    public DateTime InsertedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}