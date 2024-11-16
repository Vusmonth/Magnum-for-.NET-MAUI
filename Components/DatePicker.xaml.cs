using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalon.Maui.Magnum.Interfaces;
using Maui.BindableProperty.Generator.Core;

namespace Avalon.Maui.Magnum.Components;

public partial class DatePicker : ContentView, IFormComponent
{
    [AutoBindable(OnChanged = nameof(ClearError))] 
    private readonly DateTime _value = DateTime.Today;
    
    [AutoBindable] 
    private readonly string _label = String.Empty;
    
    public DatePicker()
    {
        InitializeComponent();
    }

    public string? ErrorMessage { get; set; }
    
    public void ClearError()
    {
        if (ErrorMessage != null && ErrorMessage.Length > 0)
        {
            ErrorMessage = string.Empty;
        }
    }
}