namespace Test

open System
open Avalonia
open Avalonia.Controls


type MyControlBase<'T> () =
    inherit Canvas ()

    let mutable test = null
    static let TestProperty =
        AvaloniaProperty.RegisterDirect<MyControlBase<'T>, string>
            ("Test", (fun o -> o.Test), (fun o v -> o.Test <- v))

    member this.Test
        with get () = test
        and set value =
            this.SetAndRaise (TestProperty, &test, value) |> ignore
