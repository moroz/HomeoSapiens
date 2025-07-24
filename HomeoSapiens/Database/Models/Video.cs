using System;
using System.ComponentModel.DataAnnotations;

namespace HomeoSapiens.Database.Models;

public class Video
{
    public Guid Id { get; set; } = Guid.CreateVersion7();

    [MaxLength(255)] public required string YoutubeId { get; set; }
    [MaxLength(255)] public required string Slug { get; set; }
    [MaxLength(255)] public string? NamePl { get; set; }
    [MaxLength(255)] public required string NameEn { get; set; }

    [MaxLength(65535)] public string? DescriptionPl { get; set; }
    [MaxLength(65535)] public required string DescriptionEn { get; set; }

    public DateTime InsertedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}