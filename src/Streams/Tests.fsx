#r "../../bin/Streams.Core.dll"

open Nessos.Streams

#time

let data = [| 1..10000000 |] |> Array.map int64

Stream.ofArray data
|> Stream.filter (fun v -> v % 2L = 0L)
|> Stream.map (fun v -> v + 1L)
|> Stream.sum

ParStream.ofArray data
|> ParStream.filter (fun v -> v % 2L = 0L)
|> ParStream.map (fun v -> v + 1L)
|> ParStream.sum

#r "../../bin/FSharp.Collections.ParallelSeq.dll"

open FSharp.Collections.ParallelSeq

PSeq.ofArray data
|> PSeq.filter (fun v -> v % 2L = 0L)
|> PSeq.map (fun v -> v + 1L)
|> PSeq.sum

data
|> Seq.filter (fun v -> v % 2L = 0L)
|> Seq.map (fun v -> v + 1L)
|> Seq.sum
