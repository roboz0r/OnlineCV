namespace App

open Feliz
open Feliz.MaterialUI
open Fable.MaterialUI

module CV2 = 
    let cvBody = CV.cvBody

    let h1 (s:string) =
        Mui.container [
            prop.style [
                style.backgroundColor Colors.indigo.``900``
            ]
            container.children [
                Mui.typography [
                    typography.variant.h1
                    typography.children s
                ]
            ]
        ]
    let h2 (s:string) =
        Mui.typography [
            typography.variant.h2
            typography.children s
        ]
    let h3 (s:string) =
        Mui.typography [
            typography.variant.h3
            typography.children s
        ]

    let professionalSummary = 
        Mui.container [
            h2 "Professional Summary"
            yield! (
                cvBody.ProfessionalSummary
                |> List.map 
                    (fun p -> 
                        Mui.typography [
                            typography.paragraph true
                            typography.children [p]
                        ]
                        
                    )
            )
                
        ]
        
    let education = 
        Mui.container [
            h2 "Education"
            Mui.list (
                cvBody.Education
                |> List.collect (fun (title, subItems) -> 
                    [
                        Mui.listItem [
                            listItem.children [
                                Mui.listItemIcon [Icons.lensIcon [icon.fontSize.small]]
                                Mui.listItemText title
                            ]
                        ]
                        match subItems with
                        | [] -> ()
                        | y -> 
                            Mui.listItem [
                                Mui.list [
                                    list.dense true
                                    list.children
                                        (y 
                                        |> List.map 
                                            (fun x -> 
                                                Mui.listItem [
                                                    listItem.children [
                                                        Mui.listItemIcon [ Icons.chevronRightIcon [icon.fontSize.small]]
                                                        Mui.listItemText x
                                                    ]
                            ]))]]
                    ])
            )
        ]
        
    let employmentHistory = 
        Mui.container [
            h2 "Employment History"
            (Mui.list (
                cvBody.EmploymentHistory
                |> List.map (fun x -> Mui.listItem [Mui.typography x])
            ))
        ]
        
        
    let softwareDev = 
        Mui.container [
            h2 "In-House Software Development"
            yield! (
                cvBody.SoftwareDev
                |> List.collect (fun x -> 
                    [
                        h3 x.Title
                        yield! (x.Body |> List.map Mui.typography)
                        (Mui.list [
                            list.dense true
                            list.children 
                                (x.Bullets 
                                |> List.map 
                                    (fun x -> 
                                        Mui.listItem [
                                            Mui.listItemIcon [Icons.chevronRightIcon [icon.fontSize.small]]
                                            Mui.listItemText x
                                        ]))
                            ])
                    ]
                )
            )
        ]
        
    let projectExp = 
        Mui.container [ 
            h2 "Project Experience"
            yield! (
                cvBody.ProjectExp
                |> List.collect (fun x -> 
                    [
                        h3 x.Title
                        yield! (x.Body |> List.map Mui.typography)
                        (Mui.list [
                            list.dense true
                            list.children 
                                (x.Bullets 
                                |> List.map 
                                    (fun x -> 
                                        Mui.listItem [
                                            Mui.listItemIcon [Icons.chevronRightIcon [icon.fontSize.small]]
                                            Mui.listItemText x
                                        ]))
                            ])
                    ]
                )
            )
                
        ]
        
    let otherProjects = 
        Mui.container [
            h2 "Many Other Projects"
            Mui.list (
                cvBody.ProjectOthers |> List.map (fun x -> Mui.listItem [(h3 x)])
            )
        ]
        

open CV2

type CV2 = 
    
    static member CV() = 
        Mui.container [
            container.disableGutters true
            container.maxWidth.md
            container.children [
                Mui.paper [
                    prop.style [style.padding 25]
                    paper.elevation 3
                    paper.children [
                        h1 "Robert Lenders"
                        professionalSummary
                        education
                        employmentHistory
                        softwareDev
                        projectExp
                        otherProjects
                    ]
                ]]
        ]