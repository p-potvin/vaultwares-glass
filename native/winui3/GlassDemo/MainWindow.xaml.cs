using Microsoft.UI.Composition.SystemBackdrops;
using Microsoft.UI.Xaml;

namespace GlassDemo;

public sealed partial class MainWindow : Window
{
    private MicaController? _micaController;
    private DesktopAcrylicController? _acrylicController;
    private readonly SystemBackdropConfiguration _configSource = new();

    public MainWindow()
    {
        InitializeComponent();
        Title = "VaultWares Glass · WinUI 3 Glass Demo";
        ExtendsContentIntoTitleBar = true;

        // Window sizing
        var appWindow = this.AppWindow;
        appWindow.Resize(new Windows.Graphics.SizeInt32(820, 600));

        Activated += OnActivated;
        Closed += OnClosed;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    77777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777xx                     

        // Default: Mica
        ApplyMica();
    }

    // ── Backdrop switching ───────────────────────────────

    private void OnBackdropChanged(object sender, RoutedEventArgs e)
    {
        ResetBackdrop();

        if (MicaRadio.IsChecked == true)
            ApplyMica();
        else if (MicaAltRadio.IsChecked == true)
            ApplyMicaAlt();
        else if (AcrylicRadio.IsChecked == true)
            ApplyAcrylic();
    }

    // ── Mica ─────────────────────────────────────────────

    private void ApplyMica()
    {
        if (!MicaController.IsSupported())
        {
            StatusText.Text = "⚠ Mica is not supported on this device.";
            return;
        }

        _micaController = new MicaController { Kind = MicaKind.Base };
        _micaController.AddSystemBackdropTarget(this.As<Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop>());
        _micaController.SetSystemBackdropConfiguration(_configSource);
        StatusText.Text = "✓ Mica backdrop active";
    }

    private void ApplyMicaAlt()
    {
        if (!MicaController.IsSupported())
        {
            StatusText.Text = "⚠ Mica is not supported on this device.";
            return;
        }

        _micaController = new MicaController { Kind = MicaKind.BaseAlt };
        _micaController.AddSystemBackdropTarget(this.As<Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop>());
        _micaController.SetSystemBackdropConfiguration(_configSource);
        StatusText.Text = "✓ Mica Alt backdrop active";
    }

    // ── Acrylic ──────────────────────────────────────────

    private void ApplyAcrylic()
    {
        if (!DesktopAcrylicController.IsSupported())
        {
            StatusText.Text = "⚠ Acrylic is not supported on this device.";
            return;
        }

        _acrylicController = new DesktopAcrylicController();
        _acrylicController.AddSystemBackdropTarget(this.As<Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop>());
        _acrylicController.SetSystemBackdropConfiguration(_configSource);
        StatusText.Text = "✓ Desktop Acrylic backdrop active";
    }

    // ── Lifecycle ────────────────────────────────────────

    private void OnActivated(object sender, WindowActivatedEventArgs args)
    {
        _configSource.IsInputActive = args.WindowActivationState != WindowActivationState.Deactivated;
    }

    private void OnClosed(object sender, WindowEventArgs args)
    {
        ResetBackdrop();
    }

    private void ResetBackdrop()
    {
        _micaController?.Dispose();
        _micaController = null;
        _acrylicController?.Dispose();
        _acrylicController = null;
    }
}
