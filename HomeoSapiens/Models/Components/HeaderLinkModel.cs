namespace HomeoSapiens.Models.Components;

public class HeaderLinkModel
{
    public required string Href { get; init; }
    public required string Children { get; init; }

    public string? ClassName { get; init; }
}