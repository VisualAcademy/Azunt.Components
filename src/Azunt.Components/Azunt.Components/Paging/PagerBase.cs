﻿namespace Azunt.Components.Paging;

public class PagerBase
{
    public string Url { get; set; } = "";
    public int PageCount { get; set; } = 5;
    public int RecordCount { get; set; } = 50;
    public int PageSize { get; set; } = 10;
    public int PageIndex { get; set; } = 0;
    public int PageNumber { get; set; } = 1;
    public int PagerButtonCount { get; set; } = 3;

    public bool SearchMode { get; set; } = false;
    public string SearchField { get; set; } = "";
    public string SearchQuery { get; set; } = "";
}