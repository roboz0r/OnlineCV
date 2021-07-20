namespace App

open Feliz
open Feliz.MaterialUI

module Theme = 
    let defaultTheme = Styles.createMuiTheme()

    let lightTheme = Styles.createMuiTheme([
      theme.palette.type'.light
      theme.palette.primary Colors.indigo
      theme.palette.secondary Colors.green
      theme.palette.error'.main "#f00"
      theme.palette.background.default' "#fff"
      theme.typography.h1.fontSize "3rem"
      theme.typography.h2.fontSize "2rem"
      theme.typography.h3.fontSize "1.5rem"

      theme.typography.h1.color Colors.grey.``50``
      theme.typography.h2.color Colors.indigo.``800``

    ])

type Theme =

    [<ReactComponent>]
    static member Theme() = 
        Mui.themeProvider [
            themeProvider.theme Theme.lightTheme
            themeProvider.children [
                Components.Router()
                ]
        ]