using Microsoft.AspNetCore.Components;
using System.Timers;

namespace Azunt.Components.Search;

public partial class SearchBox : ComponentBase, IDisposable
{
    #region Fields
    private string searchQuery = "";
    private System.Timers.Timer? debounceTimer;
    #endregion

    #region Parameters
    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object> AdditionalAttributes { get; set; } = new Dictionary<string, object>();

    // Pass information from the child component to the parent component
    [Parameter]
    public EventCallback<string> SearchQueryChanged { get; set; }

    [Parameter]
    public int Debounce { get; set; } = 300;
    #endregion

    #region Properties
    public string SearchQuery
    {
        get => searchQuery;
        set
        {
            searchQuery = value;
            debounceTimer?.Stop(); // Stop timer while typing
            debounceTimer?.Start(); // Restart timer (fires once after the debounce interval)
        }
    }
    #endregion

    #region Lifecycle Methods
    protected override void OnInitialized()
    {
        debounceTimer = new System.Timers.Timer
        {
            Interval = Debounce,
            AutoReset = false // Ensure it runs only once per trigger
        };
        debounceTimer.Elapsed += SearchHandler!;
    }
    #endregion

    #region Event Handlers
    protected void Search()
        => SearchQueryChanged.InvokeAsync(SearchQuery); // Send search query to the parent component

    protected async void SearchHandler(object? source, ElapsedEventArgs e)
    {
        await InvokeAsync(() => SearchQueryChanged.InvokeAsync(SearchQuery));
    }
    #endregion

    #region Public Methods
    public void Dispose()
    {
        debounceTimer?.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion
}
