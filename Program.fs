[<AbstractClass>]
type Reader() =
    abstract Warnings: ResizeArray<string> with get

let reader =
    let warnins = ResizeArray<string>()
    { new Reader() with
        member __.Warnings = warnins
    }

reader.Warnings.Add("Warning 1")
reader.Warnings.Add("Warning 2")

printfn "Count: %A" reader.Warnings.Count
