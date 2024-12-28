using System.Text;
using System.Threading.Tasks;
using BlazorComponentUtilities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Maurosoft.Blazor.Tailwind.Core.Interfaces;
using Maurosoft.Blazor.Tailwind.Core.Css;
using Maurosoft.Blazor.Tailwind.Core.ExtensionMethods;
using Microsoft.AspNetCore.Components.Rendering;
using Maurosoft.Blazor.Tailwind.Core.Enums;

namespace Maurosoft.Blazor.Tailwind.Core;

public abstract class BlazorComponentBase : ComponentBase, IDisposable, IAsyncDisposable, IBlazorComponentBase
{
    #region Fields and Constants
    protected bool isCompletedRender = false;

    protected const string JsPath = "./_content/Maurosoft.Blazor.Tailwind.Core/js";

    protected IJSObjectReference _jsFlowbiteModule = default!;

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

    public virtual bool LoadFlowbiteLibrary { get; set; } = true;

    public virtual bool HasJavascript { get; set; } = false;

    public virtual string JavascriptFile { get; set; } = "";

    #endregion

    #region Parameter
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> AdditionalAttributes { get; set; } = default!;

    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;

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

    /// <summary>
    /// 
    /// </summary>
    [Parameter]
    public List<ITailwindCssProperty> CssProperties { get; set; } = [];
    #endregion

    #region Services
    [Inject]
    protected IGeneratorId GeneratorId { get; set; } = default!;

    [Inject]
    protected IJSRuntime JSRuntime { get; set; } = default!;
    #endregion

    #region Public Method, Properties
    public ElementReference Element { get; set; }

    protected List<ITailwindCssProperty> _cssProperties { get; set; } = [];

    public void AddOrUpdateCssProperty(ITailwindCssProperty cssProperty, bool stateHasChanged = true) =>
        AddOrUpdateCssProperties([cssProperty], stateHasChanged);

    public void AddOrUpdateCssProperties(IList<ITailwindCssProperty> cssProperties, bool stateHasChanged = true)
    {
        foreach (var cssProperty in cssProperties)
            _cssProperties.UpdateOrAddValueIfNotExist(cssProperty);

        if (stateHasChanged)
            InvokeAsync(() => StateHasChanged());
    }

    public string RenderCssProperty(TailwindCssPropertyScopeBase tailwindCssPropertyScopeBase = TailwindCssPropertyScopeBase.All) =>
        _cssProperties.Where(w => w.Scope == tailwindCssPropertyScopeBase).RenderCssProperty();
    #endregion

    #region Override ComponentBase

    protected override void OnInitialized()
    {
        isCompletedRender = false;

        if (ShouldAutoGenerateId && Id == null)
            Id = GeneratorId.GetNextId(IdSuffix);

        if (CssProperties.Count > 0)
            foreach (var param in CssProperties)
                _cssProperties.Add(param);

        OnInitializeCssProperties();
    }

    protected override void OnParametersSet()
    {
        OnGenerateCssClasses();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            isCompletedRender = true;

            if (LoadFlowbiteLibrary)
                _jsFlowbiteModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", $"{JsPath}/flowbite.min.js");
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
    protected virtual async ValueTask DisposeAsync(bool disposing)
    {
        try
        {
            if (!AsyncDisposed)
            {
                AsyncDisposed = true;
            }

            if (LoadFlowbiteLibrary && _jsFlowbiteModule != null)
                await _jsFlowbiteModule.DisposeAsync();
        }
        catch
        {
            // do nothing
        }
    }
    #endregion

    #region Other
    ~BlazorComponentBase()
    {
        Dispose(false);
    }
    #endregion
}
