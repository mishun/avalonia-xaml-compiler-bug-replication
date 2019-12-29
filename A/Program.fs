module Test.Program

open System
open Avalonia


let BuildAvaloniaApp() =
    AppBuilder.Configure<App>()
        .UsePlatformDetect()

[<EntryPoint>]
let main (args: string[]) =
    BuildAvaloniaApp().StartWithClassicDesktopLifetime(args)
