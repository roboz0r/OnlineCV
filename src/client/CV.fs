module CV

open Feliz
open Feliz.MaterialUI

let cvBody = 
    {|
        ProfessionalSummary = 
            [
                "In the past 10 years, I have worked as a process engineer and recently project manager \
                in traditional engineering, primarily the oil and gas industry as well as bioprocessing, \
                specialist laboratory environments and manufacturing. During that time, I have also \
                actively taught myself programming skills to better serve my engineering tasks and \
                now wish to transition to software development as a career pursuit."
                
                "I have experience in many programming languages, from humble VBA scripts \
                to complete solutions using C# and F#. F# is the language that has captured my passion \
                recently with its expressiveness and emphasis on the functional paradigm, type safety \
                and immutability."
                
                "I am keen to use the multi-disciplinary skills that I bring to develop software solutions \
                that merge the safety, quality and technical standards associated with the process industry \
                with the rapid development and scale of the software industry."
                
                "I have produced Quality Management Systems to achieve ISO 9001 certification and in-house \
                tools to aid in engineering, project management and business finances. I have also written \
                engineering design guides and calculation tools for client companies. Such projects suit \
                my precise, systems-oriented thinking, which I have applied successfully throughout my \
                career. I have also enjoyed leading small teams and helping my colleagues develop their skills."    
                
                "In my free time I am currently exploring web development technologies using F# and \
                Azure Functions & CosmosDB to create SPA’s with shared client and server domain logic \
                in source files."
            ]
        Education = 
            [ 
                "Self-guided education in programming and related technologies (2012 – present):", 
                    [
                     ".Net Framework, Core & 5.0 (C# and F#)"
                     "JavaScript interop (using F# & Fable)"
                     "ReactJS, WPF and WinForms"
                     "Azure CosmosDB, SQLite and MSSQL"
                     "Azure Functions"
                     "Automated testing using Expecto, NUnit and xUnit"
                     "Source control using Git"
                     "VBA and Power Query"
                     "Some experience with Python, C and JavaScript" ]
                "HAZOP Leader Training Course (Orica), 2015", []
                "Bachelor of Engineering (Chemical - Honours), RMIT University Melbourne, 2012", []
                "Bachelor of Applied Science (Chemistry), RMIT University Melbourne, 2012", []
            ]
        EmploymentHistory = 
            [
                "Vecta Group, Senior Process Engineer, August 2017 to Present"
                "OGC Engineering, Process Engineer, December 2015 to July 2017"
                "Amec and CloughAmec, Student/Graduate Process Engineer, September 2010 to July 2015"
            ]
        SoftwareDev = 
            [
                {|
                    Title = "Document Management System"
                    Body = 
                        [
                            "This system utilised Excel as the front end for a multi-user \
                            document management system backed by an SQLite database to be \
                            run on our internal local network. I implemented a three-way \
                            data validation and merge system to allow multiple users to \
                            commit changes to the database from semi-structured Excel tables \
                            asynchronously."
                            "The software also allowed users to transmit documents to our \
                            clients using their Microsoft 365 account and the Microsoft \
                            Graph API. All code was written in F#."
                        ]
                    Bullets = []
                |}
                {|
                    Title = "Restriction Orifice Sizing"
                    Body = 
                        [
                            "This Aspen HYSYS and UniSim Extension allows for the simple \
                            sizing of restriction orifices in both sonic and subsonic gas \
                            service as well as liquid service. I developed this to address \
                            a limitation where orifice sizing was not correctly modelled, \
                            particularly in sonic flowing conditions. This extension was \
                            written using C# and the COM interop features of Aspen HYSYS."
                        ]
                    Bullets = []
                |}
                {|
                    Title = "Employee Tracker"
                    Body = 
                        [
                            "This online database app was developed to track employee \
                            information using the low-code platform Knack. It was \
                            developed in close consultation with the HR and Business \
                            Development Managers who would be the ultimate product owners. \
                            As part of their requirements to allow full text searching of \
                            resumes, I implemented an event handler which automatically \
                            converted multi-format resumes to searchable plain text \
                            using Azure Functions."
                        ]
                    Bullets = []
                |}
                {|
                    Title = "Spreadsheet Applications"
                    Body = 
                        [
                            "I have developed numerous spreadsheets using Excel, VBA \
                            and Power Query including integration with 3rd party native \
                            dll’s and custom built managed (C# and F#) code. These \
                            spreadsheets perform either ETL-type workflows from \
                            heterogeneous data sources or engineering design calculations \
                            based on published systems of equations."
                        ]
                    Bullets = 
                        [
                            "Project performance financial reporting"
                            "Incompressible & Compressible fluid flow"
                            "Equilibrium temperature of a surface under radiation"
                            "Two and three phase horizonal and vertical separators"
                            "Vertical flare sizing to API 521"
                            "Relief valve sizing to API 520"
                            "Relief rate estimation to API 521"
                            "Control valve sizing"
                            "Pump sizing"
                            "3-Phase property calculation leveraging Aspen Properties"
                        ]
                |}
            ]
        ProjectExp = 
            [
                {|
                    Title = "Viva Energy Australia, Jet Plume Remediation System"
                    Body = 
                        [
                            "I was responsible for the project management and process \
                            engineering of the project which involved the EPC of an \
                            underground piping network, tank storage and loadout bay \
                            to remove contamination from the groundwater due to a \
                            hydrocarbon spill. My responsibilities included:"
                        ]
                    Bullets = 
                        [
                            "Process engineering design of the system"
                            "Approval of other engineering documents"
                            "Coordination of engineering and construction personnel"
                            "Procurement of materials and subcontractors"
                            "Cost control and reporting"
                        ]
                |}
                {|
                    Title = "Cooper Energy, Cooper Energy Management System"
                    Body = 
                        [
                            "This project involved a complete overhaul of Cooper’s \
                            corporate management systems including the development \
                            of standards and procedures to obtain a Major Hazard \
                            Facility licence to operate for their newly acquired \
                            Athena Gas Plant. I was responsible for writing their \
                            process safety protocols and procedures and contributing \
                            to several other areas including integrity and reliability \
                            management, work management and OHS."
                        ]
                    Bullets = []
                |}
                {|
                    Title = "APA Group, Orbost Gas Plant, Commissioning"
                    Body = 
                        [
                            "This project commissioned the newly upgraded facility for \
                            processing the Sole gas field, which included H2S. My \
                            responsibilities included writing and execution of \
                            commissioning procedures as well as providing engineering \
                            support and risk analysis to the design engineering, \
                            construction, pre-commissioning and other operations activities."
                        ]
                    Bullets = []
                |}
                {|
                    Title = "PPG, Future Paint Facility, FEED"
                    Body = 
                        [
                            "This project involved the design of a new water-based paint \
                            facility to support their operations. My responsibilities included:"
                        ]
                    Bullets = 
                        [
                            "P&ID design and drafting in AutoCAD"
                            "Updating the control system philosophy"
                            "Performing equipment sizing"
                        ]
                |}
                {|
                    Title = "APA Group, Engineering Management Framework 2"
                    Body = 
                        [
                            "This project involved the update of APA’s engineering management \
                            framework. I was responsible for preparing a complete suite of \
                            process engineering design standards and validated standard calculation tools."
                        ]
                    Bullets = []
                |}
                {|
                    Title = "Quality Assurance System to ISO 9001"
                    Body = 
                        [
                            "I assisted with the development of internal procedures and quality \
                            assurance systems to achieve ISO 9001 certification at OGC Engineering and Vecta Group."
                        ]
                    Bullets = []
                |}
                {|
                    Title = "Lochard Energy, Iona Gas Plant, SafeX Operating Procedures"
                    Body = 
                        [
                            "This project involved rewriting existing operating procedures to match \
                            the current plant operating philosophy. I was responsible for writing and \
                            editing the procedures as well as conducting interviews with the operations \
                            team to fill gaps in the existing operations documents."
                        ]
                    Bullets = []
                |}
            ]
        ProjectOthers = 
            [
                "Viva Energy Australia, Newport Terminal Jet Fuel Upgrades"
                "WestSide Corporation, Moura Development Hydraulic Study"
                "Central Petroleum, Griffin Gas Plant Relocation"
                "AGL, Wallumbilla LPG Plant Relief System Revalidation"
                "Santos, Sole Gas Development Project"
                "AGL, Silver Springs Storage Project – Withdrawal Phase"
                "Santos, Eastern Gas Export Compressor Station and Moomba North Gas Satellite"
                "CSIRO, AAHL Fuel Delivery System Peer Review"
                "Amec Foster Wheeler, MSD Animal Health"
                "Wasco Australia, Compression and Safety Systems"
                "QGC, QCLNG Upstream Facilities- Produced Water Network"
            ]
    |}


let professionalSummary = 
    Html.div [
        Html.h2 "Professional Summary"
        yield! (
            cvBody.ProfessionalSummary
            |> List.map Html.p
        )
        
    ]

let education = 
    Html.div [
        Html.h2 "Education"
        Html.ul (
            cvBody.Education
            |> List.collect (fun (x, y) -> 
                [
                    Html.li x
                    match y with
                    | [] -> ()
                    | y -> Html.ul (y |> List.map (Html.li))
                ])
        )
    ]

let employmentHistory = 
    Html.div [
        Html.h2 "Employment History"
        (Html.ul (
            cvBody.EmploymentHistory
            |> List.map Html.li
        ))
    ]


let softwareDev = 
    Html.div [
        Html.h2 "In-House Software Development"
        yield! (
            cvBody.SoftwareDev
            |> List.collect (fun x -> 
                [
                    Html.h3 x.Title
                    yield! (x.Body |> List.map Html.p)
                    (Html.ul (x.Bullets |> List.map Html.li) )
                ]
            )
        )
    ]

let projectExp = 
    Html.div [ 
        Html.h2 "Project Experience"
        yield! (
            cvBody.ProjectExp
            |> List.collect (fun x -> 
                [
                    Html.h3 x.Title
                    yield! (x.Body |> List.map Html.p)
                    (Html.ul (x.Bullets |> List.map Html.li) )
                ]
            )
        )
        
    ]

let otherProjects = 
    Html.div [
        Html.h2 "Many Other Projects"
        Html.ul (
            cvBody.ProjectOthers |> List.map Html.h3
        )
    ]

[<ReactComponent>]
let CV() = 
    Html.div [
        Html.h1 "Robert Lenders"
        professionalSummary
        education
        employmentHistory
        softwareDev
        projectExp
        otherProjects
    ]