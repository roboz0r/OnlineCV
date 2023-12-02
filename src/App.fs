module App

open Fable.Core
open Fable.Core.JsInterop
open Browser

open Router

type Model = { Route: SiteRoute; CV: CV.Model }

[<RequireQualifiedAccess>]
type Msg =
    | NavigateTo of SiteRoute
    | CV of CV.Msg

open Elmish
open Elmish.Navigation

let setTitle route =
    document.title <- SiteRoute.getNavTitle route

let update (msg: Msg) (model: Model) =
    console.log ($"update: {msg}")

    match msg with
    | Msg.NavigateTo route ->
        let url = SiteRoute.getUrl route

        let newModel =
            setTitle route
            { model with Route = route }

        newModel, Navigation.newUrl url

    | Msg.CV msg ->
        let newModel = CV.update msg model.CV
        { model with CV = newModel }, Cmd.none

open Lit
open Lit.Elmish

let hmr = HMR.createToken ()

let homeView (model: Model) (dispatch: Msg -> unit) =
    html
        $"""
    <div class="relative flex flex-col items-center max-w-3xl  bg-zinc-100 rounded-xl">

        <div class="flex max-lg:hidden flex-row space-x-32 pt-8">
            <h1 class="text-5xl font-bold text-zinc-800 underline ">Robert Lenders</h1>
            <img class="absolute top-4 right-8" src="/images/logo.png" >
            <img class="lg:hidden" src="/images/logo.png" >
        </div>

        <div class="flex lg:hidden flex-col items-center">
            <h1 class="text-5xl font-bold text-zinc-800 underline py-4">Robert Lenders</h1>
            <div><img src="/images/logo.png" ></div>
        </div>
        {CV.view model.CV (Msg.CV >> dispatch)}
    </div>
    """

[<HookComponent>]
let view (model: Model) (dispatch: Msg -> unit) =
    Hook.useHmr (hmr)

    html
        $"""
    <div class="h-full p-16 flex flex-col items-center bg-sky-700"> 
        {match model.Route with
         | SiteRoute.Home -> homeView model dispatch}
    </div>
    """

let initialState route =
    match route with
    | Some route -> { Route = route; CV = CV.init () }, Cmd.none
    | None ->
        // Redirect to home if route is invalid
        {
            Route = SiteRoute.Home
            CV = CV.init ()
        },
        Navigation.newUrl "."

let urlUpdate (result: SiteRoute option) (model: Model) =
    match result with
    | Some x -> { model with Route = x }, Cmd.none
    | None -> { model with Route = SiteRoute.Home }, Navigation.newUrl "/"

let navParser: Navigation.Parser<SiteRoute option> =
    fun location ->
        location.pathname.Split('/')
        |> List.ofArray
        |> List.tail // Path starts with '/' so there is always an empty first element
        |> SiteRoute.tryParseRoute

Program.mkProgram initialState update view
|> Program.toNavigable navParser urlUpdate
|> Program.withLit "app" // This is the id of the root element in index.html
|> Program.run
