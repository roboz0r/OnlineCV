module CV

type SoftwareDev =
    {
        Title: string
        Url: string option
        Body: string list
        Bullets: string list
    }

type ProjectExp =
    {
        Title: string
        Body: string list
        Bullets: string list
    }

type CVBody =
    {
        ProfessionalSummary: string list
        Education: (string * string list) list
        EmploymentHistory: string list
        SoftwareDev: SoftwareDev list
        ProjectExp: ProjectExp list
        ProjectOthers: string list
    }

let cvBody =
    {
        ProfessionalSummary =
            [
                "With over 10 years of process engineering experience, I have worked on Concept, FEED, Detailed Design, and Commissioning projects in the oil and gas industry. I have also provided Concept and FEED engineering services in bioprocessing, specialist laboratory environments, and manufacturing."
                "In addition to being a skilled and passionate engineer, I am an experienced software developer with a focus on F# due to its expressiveness and emphasis on the functional programming paradigm, type safety, and immutability. With an aim to improve the tools available to engineers and other professionals, I created the Sharp Cells add-in for Excel which tightly integrates F# as a powerful scripting language for custom functions and commands in Excel."
                "I am keen to use the multi-disciplinary skills that I bring to develop software solutions that merge the safety, quality, and technical standards associated with the process industry with the rapid development and scale of the software industry."
                "I have produced Quality Management Systems to achieve ISO 9001 certification and in-house tools to aid in engineering, project management, and business finances. I have also written engineering design guides and calculation tools for client companies. Such projects suit my precise, systems-oriented thinking, which I have applied successfully throughout my career. I have also enjoyed leading small teams and helping my colleagues develop their skills."
            ]
        Education =
            [
                "Self-guided education in software development and related technologies (2012 – present):",
                [
                    ".NET Framework, Core & 5+ (C# and F#)"
                    "JavaScript interop (using F# & Fable)"
                    "Lit, ReactJS, WPF and WinForms"
                    "Azure CosmosDB, SQLite and MSSQL"
                    "Azure Functions"
                    "Automated testing using Expecto, NUnit and xUnit"
                    "Source control using Git"
                    "VBA and Power Query"
                    "Some experience with Python, C and JavaScript"
                ]
                "HAZOP Leader Training Course (Orica), 2015", []
                "Bachelor of Engineering (Chemical - Honours), RMIT University Melbourne, 2012", []
                "Bachelor of Applied Science (Chemistry), RMIT University Melbourne, 2012", []
            ]
        EmploymentHistory =
            [
                "Oehm Automation, Senior Software Engineer, Oct 2023 to Present"
                "Sharp Cells, Founder and Principal Software Engineer, Sep 2022 to Present"
                "Primacy Technology, Senior Software Developer, Feb 2022 to Sep 2022"
                "Vecta Group, Senior Process Engineer, Aug 2017 to Feb 2022"
                "OGC Engineering, Process Engineer, Dec 2015 to Jul 2017"
                "Amec and CloughAmec, Student/Graduate Process Engineer, Sep 2010 to Jul 2015"
            ]
        SoftwareDev =
            [
                {
                    Title = "Sharp Cells"
                    Url = Some "https://www.sharpcells.com"
                    Body =
                        [
                            "Sharp Cells is an xll-based Excel add-in that allows users to write custom \
                            functions and commands in F# and other .NET languages. It is a \
                            commercial product that I developed and maintain. It is written in F#."
                        ]
                    Bullets =
                        [
                            "Integrates F# as a scripting language for Excel"
                            "Interop between Excel's C and COM APIs and a user's F# scripts"
                            "Supports creating UDFs connected to real-time data sources"
                            "Engaged with users and potential users to understand their needs, adding features and fixing bugs as required"
                            "Integrated with APIs to manage identity and licensing"
                        ]
                }
                {
                    Title = "Document Management System"
                    Url = None
                    Body =
                        [
                            "This program used Excel as the front end for a multi-user \
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
                }
                {
                    Title = "Restriction Orifice Sizing"
                    Url = None
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
                }
                {
                    Title = "Employee Tracker"
                    Url = None
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
                }
                {
                    Title = "Spreadsheet Applications"
                    Url = None
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
                }
            ]
        ProjectExp =
            [
                {
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
                }
                {
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
                }
                {
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
                }
                {
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
                }
                {
                    Title = "APA Group, Engineering Management Framework 2"
                    Body =
                        [
                            "This project involved the update of APA’s engineering management \
                            framework. I was responsible for preparing a complete suite of \
                            process engineering design standards and validated standard calculation tools."
                        ]
                    Bullets = []
                }
                {
                    Title = "Quality Assurance System to ISO 9001"
                    Body =
                        [
                            "I assisted with the development of internal procedures and quality \
                            assurance systems to achieve ISO 9001 certification at OGC Engineering and Vecta Group."
                        ]
                    Bullets = []
                }
                {
                    Title = "Lochard Energy, Iona Gas Plant, SafeX Operating Procedures"
                    Body =
                        [
                            "This project involved rewriting existing operating procedures to match \
                            the current plant operating philosophy. I was responsible for writing and \
                            editing the procedures as well as conducting interviews with the operations \
                            team to fill gaps in the existing operations documents."
                        ]
                    Bullets = []
                }
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
    }


type Model =
    {
        Content: CVBody
    }

let init () =
    {
        Content = cvBody
    }

type Msg = unit

let update (msg: Msg) (model: Model) = model

open Lit

let professionalSummary =
    html
        $"""
        <div>
            <h2>Professional Summary</h2>
            {cvBody.ProfessionalSummary |> List.map (fun x -> html $"<p>{x}</p>")}
        </div>
    """

let inline private p content : TemplateResult = html $"<p>{content}</p>"

let inline private li content : TemplateResult = html $"<li>{content}</li>"

let inline private ul content : TemplateResult = html $"<ul>{content}</ul>"

let education =
    html
        $"""
        <div>
            <h2>Education</h2>
            <ul>
                {cvBody.Education
                 |> List.map (fun (x, y) ->
                     [
                         li x
                         match y with
                         | [] -> ()
                         | y -> ul (y |> List.map li)
                     ])}
            </ul>
        </div>
    """

let employmentHistory =
    html
        $"""
        <div>
            <h2>Employment History</h2>
            <ul>
                {cvBody.EmploymentHistory |> List.map li}
            </ul>
        </div>
    """

let softwareDevItem (tabIndex: int) (x: SoftwareDev)  =
    html
        $"""
    <div tabindex="{tabIndex}" class="collapse collapse-arrow m-2 p-2 rounded-lg border-2 border-sky-900">
        <div class="collapse-title text-xl font-medium">
            <span>{x.Title}</span>
            {match x.Url with
             | Some url -> html $"<span class=\"pl-8\"><a href={url} target=\"_blank\">{url}</a></span>"
             | None -> Lit.nothing}
        </div>
        <div class="collapse-content"> 
            {x.Body |> List.map p}
            <ul>{x.Bullets |> List.map li}</ul>
        </div>
    </div>
    """

let softwareDev model dispatch =
    html
        $"""
        <h2>Software Development</h2>
        <div class="">
            {model.SoftwareDev |> List.mapi softwareDevItem}
        </div>
    """

let projectExpItem (tabIndex: int) (x: ProjectExp) =
    html
        $"""
    <div tabindex="{tabIndex}" class="collapse collapse-arrow m-2 p-2 rounded-lg border-2 border-sky-900">
        <div class="collapse-title text-xl font-medium">
            <span>{x.Title}</span>
        </div>
        <div class="collapse-content"> 
            {x.Body |> List.map p}
            <ul>{x.Bullets |> List.map li}</ul>
        </div>
    </div>
    """

let projectExp model dispatch =
    let offset = model.SoftwareDev |> List.length
    html
        $"""
        <h2>Engineering Project Experience</h2>
        <div class="">
            {model.ProjectExp |> List.mapi (fun i x -> projectExpItem (i + offset) x)}
        </div>
    """

let otherProjects =
    html
        $"""
        <div>
            <h2>Many Other Projects</h2>
            <ul>
                {cvBody.ProjectOthers |> List.map li}
            </ul>
        </div>
    """

let hmr = HMR.createToken ()

let proseClasses = 
    [
        "prose"
        "prose-slate"
        "prose-code:font-mono"
        "prose-code:font-semibold"
        "prose-code:before:content-['']" // Remove unnecessary backticks
        "prose-code:after:content-['']"
        "prose-img:border"
        "prose-img:border-solid"
        "prose-img:border-slate-500"
        "prose-pre:border"
        "prose-pre:border-solid"
        "prose-pre:border-slate-500"
        "prose-a:text-anchor"
        "max-w-3xl"
        "text-large"
        "p-3 xl:p-6"
        "min-w-0"
    ] |> Lit.classes

[<HookComponent>]
let view (model: Model) (dispatch: Msg -> unit) =
    Hook.useHmr (hmr)

    html
        $"""
        <article class="{proseClasses}">
            {professionalSummary}
            {education}
            {employmentHistory}
            {softwareDev model.Content dispatch}
            {projectExp model.Content dispatch}
            {otherProjects}
        </article>
    """
