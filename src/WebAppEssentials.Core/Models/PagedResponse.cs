namespace WebAppEssentials.Models;

/// <summary>
/// Represents a paginated response containing a list of items and pagination metadata.
/// </summary>
/// <typeparam name="T">The type of items in the response.</typeparam>
public class PagedResponse<T>
{
    /// <summary>
    /// Gets or sets the list of items in the response.
    /// </summary>
    /// <value>The list of items.</value>
    public required List<T> Items { get; set; }

    /// <summary>
    /// Gets or sets the total number of items available.
    /// </summary>
    /// <value>The total number of items.</value>
    public int TotalCount { get; set; }

    /// <summary>
    /// Gets or sets the total number of pages based on the current page size.
    /// </summary>
    /// <value>The total number of pages.</value>
    public int TotalPages { get; set; }

    /// <summary>
    /// Gets or sets the current page number.
    /// </summary>
    /// <value>The current page number.</value>
    public int Page { get; set; }

    /// <summary>
    /// Gets or sets the number of items per page.
    /// </summary>
    /// <value>The number of items per page.</value>
    public int PageSize { get; set; }
}