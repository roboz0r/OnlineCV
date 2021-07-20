namespace App

open Feliz
open Feliz.Router
open Feliz.MaterialUI

type Components =

    [<ReactComponent>]
    static member Router() =
        let (currentUrl, updateUrl) = React.useState(Router.currentUrl())
        React.router [
            router.onUrlChanged updateUrl
            router.children [
                match currentUrl with
                | [ ] -> CV2.CV()
                | _ -> Html.h1 "Not found"
            ]
        ]
