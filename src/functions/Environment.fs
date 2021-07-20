module OnlineCV.Server.Environment

open System

let private getEnvVar key =
    Environment.GetEnvironmentVariable(key, EnvironmentVariableTarget.Process)
    |> function
    | null -> failwithf "Environment variable '%s' not found." key
    | x -> x

let PrimConnString () = getEnvVar ("PrimConnString")
