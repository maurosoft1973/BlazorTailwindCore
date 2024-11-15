using System.Text;
using System.Threading.Tasks;
using BlazorComponentUtilities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Maurosoft.Blazor.Tailwind.Core.Interfaces;
using Maurosoft.Blazor.Tailwind.Core.Css;
using Maurosoft.Blazor.Tailwind.Core.ExtensionMethods;

namespace Maurosoft.Blazor.Tailwind.Core;

public abstract class BlazorComponentBase : ComponentBase, IDisposable, IAsyncDisposable, IBlazorComponentBase
{
    #region Fields and Constants
    protected bool isCompletedRender = false;
    protected bool requiredRender = false;

    protected const string jsPath = "./_content/Maurosoft.Blazor.Tailwind.Core/js";

    protected IJSObjectReference _jsModule = default!;

    /// <summary>
    /// If true, <see cref="Id" /> will be auto-generated on component initialize.
    /// </summary>
    /// <remarks>
    /// Override this in components that need to have an id defined before calling JSInterop.
    /// </remarks>
    protected virtual bool ShouldAutoGenerateId => false;

    protected virtual string IdSuffix => "";

    protected abstract void OnInitializeCssProperties();

    protected abstract void OnGenerateCssClasses();

    #endregion

    #region Javascript

    public virtual bool HasJavascript { get; set; } = false;

    public virtual string JavascriptFile { get; set; } = "";

    #endregion

    #region Parameter
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> AdditionalAttributes { get; set; } = default!;

    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;

    [Parameter]
    public bool PrerenderingMode { get; set; } = false;

    /// <summary>
    /// Gets or sets the unique id of the element.
    /// </summary>
    /// <remarks>
    /// Note that this ID is not defined for the component but instead for the underlined element that it represents.
    /// </remarks>
    [Parameter]
    public string? Id { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [Parameter]
    public virtual bool Visible { get; set; } = true;

    /// <summary>
    /// 
    /// </summary>
    [Parameter]
    public virtual bool Disabled { get; set; } = false;

    /// <summary>
    /// 
    /// </summary>
    [Parameter]
    public virtual string Label { get; set; } = "";

    /// <summary>
    /// 
    /// </summary>
    [Parameter]
    public virtual string Tooltip { get; set; } = "";
    #endregion

    #region Services
    [Inject]
    protected IGeneratorId GeneratorId { get; set; } = default!;

    [Inject]
    protected IJSRuntime JSRuntime { get; set; } = default!;
    #endregion

    #region Public Method, Properties
    public ElementReference Element { get; set; }

    public List<ITailwindCssPropertyBase> CssProperties { get; set; } = [];

    public void AddCssProperty(ITailwindCssPropertyBase cssProperty)
    {
        requiredRender = true;
        CssProperties.UpdateOrAddValueIfNotExist(cssProperty);
    }

    public void RegenerateCssContainerClasses(bool stateHasChanged = false)
    {
        //ContainerCssClasses = _cssContainerProperties.BuildCssClasses(_cssPropertiesCustomBuilder);

        //if (stateHasChanged)
        //	StateHasChanged();
    }

    #endregion

    #region Override ComponentBase
    /// <inheritdoc />
    protected override void OnInitialized()
    {
        isCompletedRender = false;

        if (ShouldAutoGenerateId && Id == null)
            Id = GeneratorId.GetNextId(IdSuffix);

        OnInitializeCssProperties();
    }

    protected override void OnParametersSet()
    {
        OnGenerateCssClasses();
    }

    /// <inheritdoc />
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            isCompletedRender = true;
            _jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", $"{jsPath}/flowbite.min.js");

            if (PrerenderingMode && requiredRender)
                await InvokeAsync(StateHasChanged);
        }

        await base.OnAfterRenderAsync(firstRender);
    }
    #endregion

    #region Dispose
    /// <summary>
    /// Indicates if the component is already fully disposed (asynchronously).
    /// </summary>
    protected bool AsyncDisposed { get; private set; }

    /// <summary>
    /// Indicates if the component is already fully disposed.
    /// </summary>
    protected bool Disposed { get; private set; }

    /// <inheritdoc />
    /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/system.idisposable?view=net-6.0" />
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!Disposed)
        {
            Disposed = true;
        }
    }

    /// <inheritdoc />
    /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-disposeasync#implement-both-dispose-and-async-dispose-patterns" />
    public async ValueTask DisposeAsync()
    {
        await DisposeAsync(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
    /// </summary>
    /// <param name="disposing"></param>
    protected virtual ValueTask DisposeAsync(bool disposing)
    {
        try
        {
            if (!AsyncDisposed)
            {
                AsyncDisposed = true;
            }

            return default;
        }
        catch
        {
            // do nothing
        }

        return default;
    }
    #endregion

    #region Other
    ~BlazorComponentBase()
    {
        Dispose(false);
    }
    #endregion
}
