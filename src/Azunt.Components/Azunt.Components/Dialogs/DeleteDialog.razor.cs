using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Azunt.Components.Dialogs;

public partial class DeleteDialog
{
    #region Parameters

    /// <summary>
    /// 삭제 확인 시 호출되는 콜백
    /// </summary>
    [Parameter]
    public EventCallback<MouseEventArgs> OnClickCallback { get; set; }

    /// <summary>
    /// 모달 제목
    /// </summary>
    [Parameter]
    public string Title { get; set; } = "DELETE";

    /// <summary>
    /// 모달 본문 메시지
    /// </summary>
    [Parameter]
    public string Message { get; set; } = "Are you sure you want to delete?";

    /// <summary>
    /// 확인 버튼 텍스트
    /// </summary>
    [Parameter]
    public string ConfirmButtonText { get; set; } = "Yes";

    /// <summary>
    /// 취소 버튼 텍스트
    /// </summary>
    [Parameter]
    public string CancelButtonText { get; set; } = "Cancel";

    #endregion

    #region Properties

    /// <summary>
    /// 모달 표시 여부
    /// </summary>
    public bool IsShow { get; set; } = false;

    #endregion

    #region Public Methods

    /// <summary>
    /// 모달 열기
    /// </summary>
    public void Show() => IsShow = true;

    /// <summary>
    /// 모달 닫기
    /// </summary>
    public void Hide() => IsShow = false;

    #endregion
}
