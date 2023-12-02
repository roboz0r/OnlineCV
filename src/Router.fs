module Router

[<RequireQualifiedAccess>]
type SiteRoute =
    | Home

[<RequireQualifiedAccess>]
module SiteRoute =
    open Browser

    let getUrl =
        function
        | SiteRoute.Home -> "/"

    let tryParseRoute path =

        match path with
        | []
        | [ "" ] -> Some SiteRoute.Home
        | _ -> None
        |> function
            | Some _ as x -> x
            | None ->
                console.log $"tryParseRoute: {path} failed"
                None

    let getNavTitle =
        function
        | SiteRoute.Home -> "Fable Elmish Lit Tailwind Starter"
