namespace Test

open System
open Avalonia
open Avalonia.Controls
open Avalonia.Markup.Xaml


type MyControl () as this =
    inherit MyControlBase<string> ()

    do
        AvaloniaXamlLoader.Load this
