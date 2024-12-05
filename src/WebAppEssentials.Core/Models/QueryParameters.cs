using WebAppEssentials.Enums;

namespace WebAppEssentials.Models;

/// <summary>
/// Represents the parameters for a query operation.
/// </summary>
public class QueryParameters
{
    /// <summary>
    /// Gets or sets the page number for pagination. Default is 1.
    /// </summary>
    public int Page { get; set; } = 1;

    /// <summary>
    /// Gets or sets the number of items per page for pagination. Default is 15.
    /// </summary>
    public int PageSize { get; set; } = 15;

    /// <summary>
    /// Gets or sets the field to sort by. Default is "Id".
    /// </summary>
    public string SortField { get; set; } = "Id";

    /// <summary>
    /// Gets or sets the direction of sorting. Default is SortDirection.Ascending.
    /// </summary>
    public SortDirection SortDirection { get; set; } = SortDirection.Ascending;
}