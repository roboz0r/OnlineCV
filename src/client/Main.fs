module Main

open Feliz
open App
open Browser.Dom
open Fable.Core.JsInterop

importSideEffects "./styles/global.scss"

ReactDOM.render(
    Theme.Theme(),
    document.getElementById "feliz-app"
)