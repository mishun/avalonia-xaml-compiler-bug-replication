namespace Test

open System
open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Markup.Xaml


type App () =
    inherit Application()

    override this.Initialize () =
        AvaloniaXamlLoader.Load this

    override __.OnFrameworkInitializationCompleted () =
        base.OnFrameworkInitializationCompleted ()
        match base.ApplicationLifetime with
            | :? IClassicDesktopStyleApplicationLifetime as desktop ->
                let model = MainWindowViewModel ()
                desktop.MainWindow <- MainWindow (DataContext = model)
            | _ -> ()
