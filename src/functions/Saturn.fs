namespace OnlineCV.Server

open System
open System.IO
open Microsoft.AspNetCore.Http
open Microsoft.Azure.WebJobs
open Microsoft.Azure.WebJobs.Extensions.Http
open Microsoft.Extensions.FileProviders
open Microsoft.Extensions.Logging
open Fable.Remoting.Server
open Fable.Remoting.Giraffe
open HeyRed.Mime
open Giraffe
open Saturn
open Saturn.AzureFunctions

module Saturn =
    let staticController =
        controller {
            index
                (fun ctx ->
                    let fileName = "index.html"
                    Controller.appDirFile ctx (fileName) (MimeTypesMap.GetMimeType fileName))

            show
                (fun ctx (_: string) ->
                    Controller.appDirFile
                        ctx
                        (ctx.Request.Path.Value.[1..])
                        (MimeTypesMap.GetMimeType ctx.Request.Path.Value))

        }

    let errorHandler (ex: Exception) : HttpHandler =
        controller {
            index (fun ctx -> Controller.text ctx ex.Message)

            show
                (fun ctx id ->
                    id
                    |> sprintf "%s, %s" ex.Message
                    |> Controller.text ctx)
        }

    let notFoundHandler =
        controller {
            index (fun ctx -> Controller.text ctx "Not found")

            show
                (fun ctx id ->
                    id
                    |> sprintf "Not found, %s"
                    |> Controller.text ctx)
        }


    let routeNoType typeName methodName = $"/{methodName}"

    let defaultHandler impl : HttpHandler =
        Remoting.createApi ()
        |> Remoting.fromValue impl
        |> Remoting.withRouteBuilder routeNoType
        |> Remoting.buildHttpHandler

    let contextHandler impl : HttpHandler =
        Remoting.createApi ()
        |> Remoting.fromContext impl
        |> Remoting.withRouteBuilder routeNoType
        |> Remoting.buildHttpHandler


    let mainRouter =
        router {
            pipe_through (CORS.cors CORS.defaultCORSConfig)

            forward "" staticController
        }

    //let thothSerialiser =
    //    ThothSerializer(CamelCase, Json.extraCoders, false)

    [<FunctionName("SaturnRouter")>]
    let saturnRouter
        (
            [<HttpTrigger(AuthorizationLevel.Anonymous, Route = "{*any}")>] req: HttpRequest,
            log: ILogger,
            context: ExecutionContext
        ) =
        log.LogInformation("Request path: " + req.Path.Value)

        // TODO Fork Saturn and add execution_context CE custom operation

        // Makes files available to the App via the HttpContext
        // Refer to GetWebHostEnvironment extension method
        let webHostEnv = req.HttpContext.GetWebHostEnvironment()
        webHostEnv.WebRootPath <- Path.Combine(context.FunctionAppDirectory, "public")
        webHostEnv.WebRootFileProvider <- new PhysicalFileProvider(webHostEnv.WebRootPath)

        let svcs = req.HttpContext.RequestServices

        req.HttpContext.RequestServices <-
            { new IServiceProvider with
                member __.GetService(t: Type) =
                    if t = typeof<ExecutionContext> then
                        upcast context
                    else
                        svcs.GetService t
            }

        req
        |> azureFunction {
            host_prefix ""
            logger log
            use_router mainRouter
            error_handler errorHandler
            not_found_handler notFoundHandler
            //use_json_serializer thothSerialiser
            }
