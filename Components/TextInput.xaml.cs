using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.Maui.Magnum.Components;

public partial class TextInput : ContentView
{
    public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(TextInput), "Text", BindingMode.TwoWay);
    public static readonly BindableProperty LabelProperty = BindableProperty.Create("Label", typeof(string), typeof(TextInput), "Label", BindingMode.TwoWay);
    
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    
    public string Label
    {
        get => (string)GetValue(LabelProperty);
        set => SetValue(LabelProperty, value);
    }
    
    public TextInput()
    {
        InitializeComponent();
    }

}