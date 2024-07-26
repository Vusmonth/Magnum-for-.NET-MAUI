# Magnum for .NET MAUI

## Intro
This project is a .NET MAUI auxiliary library designed to speed up the interface development phase. Magnum contains multiple styled controls with custom properties and a collection of utilities to improve development speed and experience.

## Requirements to use
You need to know how to declare custom namespaces into your XAML file. If you have any question about this, read this: https://learn.microsoft.com/en-us/dotnet/maui/xaml/namespaces/?view=net-maui-8.0

## Behaviors

### CurrencyEntryBehavior
CurrencyEntryBehavior is a behavior for MAUI entry control that convert the typed value into a currency format.
#### How To use: 
```
// Declare the Magnum namespace oon your content page
<ContentPage ...
             xmlns:MagnumBehaviors="clr-namespace:Avalon.Maui.Magnum.Behaviors;assembly=Avalon.Maui.Magnum"> 

<Entry
    HorizontalTextAlignment="End"
    Keyboard="Numeric"****
    Placeholder="$0.00">
        <Entry.Behaviors>
             <MagnumBehaviors:CurrencyEntryBehavior />
        </Entry.Behaviors>
</Entry>
...
```