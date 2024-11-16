using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalon.Maui.Magnum.Interfaces;
using Maui.BindableProperty.Generator.Core;

namespace Avalon.Maui.Magnum.Components;

public partial class TextInput : ContentView, IFormComponent
{
    [AutoBindable] 
    private readonly string _label;

    [AutoBindable(OnChanged = nameof(ClearError), DefaultBindingMode = nameof(BindingMode.TwoWay))]
    private readonly string _text;

    [AutoBindable] 
    private readonly string? _errorMessage = null;

    [AutoBindable] 
    private readonly string _placeholder = String.Empty;
    
    [AutoBindable]
    private readonly Keyboard _keyboard = Keyboard.Default;

    public void ClearError()
    {
        if (ErrorMessage != null && ErrorMessage.Length > 0)
        {
            ErrorMessage = string.Empty;
        }
    }

    public TextInput()
    {
        InitializeComponent();
    }
}