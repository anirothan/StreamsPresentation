open System
open System.Collections.Generic

type Stream<'T> = ('T -> unit) -> unit
     
