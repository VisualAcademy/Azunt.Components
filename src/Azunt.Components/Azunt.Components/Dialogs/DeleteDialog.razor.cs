using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Azunt.Components.Dialogs;

public partial class DeleteDialog
{
    #region Parameters

    /// <summary>
    /// Callback to invoke when the delete confirmation is accepted
    /// </summary>
    [Parameter]
    public EventCallback<MouseEventArgs> OnClickCallback { get; set; }

    /// <summary>
    /// Title displayed at the top of the modal
    /// </summary>
    [Parameter]
    public string Title { get; set; } = "DELETE";

    /// <summary>
    /// Message displayed in the body of the modal
    /// </summary>
    [Parameter]
    public string Message { get; set; } = "Are you sure you want to delete?";

    /// <summary>
    /// Text for the confirmation button
    /// </summary>
    [Parameter]
    public string ConfirmButtonText { get; set; } = "Yes";

    /// <summary>
    /// Text for the cancel button
    /// </summary>
    [Parameter]
    public string CancelButtonText { get; set; } = "Cancel";

    #endregion

    #region Properties

    /// <summary>
    /// Indicates whether the modal is visible
    /// </summary>
    public bool IsShow { get; set; } = false;

    #endregion

    #region Public Methods

    /// <summary>
    /// Show the modal dialog
    /// </summary>
    public void Show() => IsShow = true;

    /// <summary>
    /// Hide the modal dialog
    /// </summary>
    public void Hide() => IsShow = false;

    #endregion
}
