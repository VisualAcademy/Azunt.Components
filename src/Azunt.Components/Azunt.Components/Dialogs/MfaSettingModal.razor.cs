using Azunt.Models.UserViewModels;
using Microsoft.AspNetCore.Components;

namespace Azunt.Components.Dialogs
{
    public class MfaSettingModalBase : ComponentBase
    {
        [Parameter] public bool Visible { get; set; }
        [Parameter] public EventCallback<bool> VisibleChanged { get; set; }

        [Parameter] public UserMfaViewModel CurrentUser { get; set; } = new();
        [Parameter] public string Error { get; set; } = string.Empty;
        [Parameter] public EventCallback OnSave { get; set; }

        [Parameter] public string AdditionalCssClass { get; set; } = "";

        protected async Task OnSaveClicked()
        {
            if (OnSave.HasDelegate)
            {
                await OnSave.InvokeAsync();
            }
        }

        protected Task Close()
        {
            return VisibleChanged.HasDelegate
                ? VisibleChanged.InvokeAsync(false)
                : Task.CompletedTask;
        }
    }
}
