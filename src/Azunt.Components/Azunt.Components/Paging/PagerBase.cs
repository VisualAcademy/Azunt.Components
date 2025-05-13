namespace Azunt.Components.Paging;

/// <summary>
/// A base class for handling pagination logic in list or search views.
/// </summary>
public class PagerBase
{
    /// <summary>
    /// The base URL to be used for page links.
    /// </summary>
    public string Url { get; set; } = "";

    /// <summary>
    /// Total number of pages to generate (e.g., based on record count and page size).
    /// </summary>
    public int PageCount { get; set; } = 5;

    /// <summary>
    /// Total number of records in the data source.
    /// </summary>
    public int RecordCount { get; set; } = 50;

    /// <summary>
    /// Number of records to display per page.
    /// </summary>
    public int PageSize { get; set; } = 10;

    /// <summary>
    /// Zero-based index of the current page (PageNumber - 1).
    /// </summary>
    public int PageIndex { get; set; } = 0;

    /// <summary>
    /// One-based current page number (e.g., 1st, 2nd, 3rd... page).
    /// </summary>
    public int PageNumber { get; set; } = 1;

    /// <summary>
    /// Number of pagination buttons to display at once (e.g., [1][2][3]).
    /// </summary>
    public int PagerButtonCount { get; set; } = 3;

    /// <summary>
    /// Indicates whether this pager is for a search result view.
    /// </summary>
    public bool SearchMode { get; set; } = false;

    /// <summary>
    /// The field to search on (e.g., Name, Title, Content).
    /// </summary>
    public string SearchField { get; set; } = "";

    /// <summary>
    /// The search keyword or phrase.
    /// </summary>
    public string SearchQuery { get; set; } = "";
}
