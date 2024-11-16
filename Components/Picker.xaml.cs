using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalon.Maui.Magnum.Interfaces;
using Maui.BindableProperty.Generator.Core;

namespace Avalon.Maui.Magnum.Components;

public partial class Picker : ContentView, IFormComponent
{
    [AutoBindable] 
    private readonly string _label = string.Empty;
    
    [AutoBindable] 
    private readonly string _placeholder = string.Empty;

    [AutoBindable] 
    private readonly List<string> _itemsSource = new();

    [AutoBindable] 
    private readonly string? _errorMessage = null;
    
    public Picker()
    {
        InitializeComponent();
    }

    public void ClearError()
    {
        if (ErrorMessage != null && ErrorMessage.Length > 0)
        {
            ErrorMessage = string.Empty;
        }
    }
}