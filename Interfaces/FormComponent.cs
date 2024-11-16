using Maui.BindableProperty.Generator.Core;

namespace Avalon.Maui.Magnum.Interfaces;

public interface IFormComponent
{ 
    string? ErrorMessage { get; set; }

    void ClearError();
}