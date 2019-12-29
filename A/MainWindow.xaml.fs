namespace Test

open System
open Avalonia
open Avalonia.Controls
open Avalonia.Controls.Shapes
open Avalonia.Layout
open Avalonia.Media
open Avalonia.Markup.Xaml


type MainWindowViewModel () =
    member this.TestValue = "test"

type MainWindow () as this =
    inherit Window ()

    do
        AvaloniaXamlLoader.Load this
