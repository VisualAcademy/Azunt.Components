using Microsoft.AspNetCore.Components;
using System.Timers;

namespace Azunt.Components.Search;

public partial class SearchBox : ComponentBase, IDisposable
{
    private string searchQuery = "";
    private System.Timers.Timer? debounceTimer;

    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object> AdditionalAttributes { get; set; } = new Dictionary<string, object>();

    [Parameter]
    public EventCallback<string> SearchQueryChanged { get; set; }

    [Parameter]
    public int Debounce { get; set; } = 300;

    public string SearchQuery
    {
        get => searchQuery;
        set
        {
            searchQuery = value;
            debounceTimer?.Stop();
            debounceTimer?.Start();
        }
    }

    protected override void OnInitialized()
    {
        debounceTimer = new System.Timers.Timer { Interval = Debounce, AutoReset = false };
        debounceTimer.Elapsed += SearchHandler!;
    }

    protected void Search() => SearchQueryChanged.InvokeAsync(SearchQuery);

    protected async void SearchHandler(object? source, ElapsedEventArgs e)
    {
        await InvokeAsync(() => SearchQueryChanged.InvokeAsync(SearchQuery));
    }

    public void Dispose() => debounceTimer?.Dispose();
}