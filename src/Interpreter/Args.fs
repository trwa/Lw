﻿(*
 * Lw
 * Args.fs: command line argument parsing
 * (C) Alvise Spano' @ Universita' Ca' Foscari di Venezia
 *)
 
module Lw.Interpreter.Args

open FSharp.Common.Prelude
open FSharp.Common.Arg
open FSharp.Common.Log
open FSharp.Common.X.Assembly
open System
open System.Reflection
open Lw
open Lw.Core.Typing

module C = Config
module CC = Core.Config

let mutable filename = ""

let credits () =
    let now = DateTime.Now
    let core_asm = Assembly.GetAssembly (typeof<Lw.Core.Globals.logger>) // get Lw.Core assembly by getting any of the type defined in it
    let asm = Assembly.GetExecutingAssembly ()
    let name = asm.GetName ()
    let ver = name.Version
    let title = get_assembly_attribute<AssemblyTitleAttribute> asm
    let core_title = get_assembly_attribute<AssemblyTitleAttribute> core_asm
    let description = get_assembly_attribute<AssemblyDescriptionAttribute> asm
    let product = get_assembly_attribute<AssemblyProductAttribute> asm
    let copyright = get_assembly_attribute<AssemblyCopyrightAttribute> asm
    let company = get_assembly_attribute<AssemblyCompanyAttribute> asm
    let productize = function
        | []  -> ""
        | [s] -> sprintf "%s is" s
        | ss ->
            let last = List.last ss
            let firsts = List.take (List.length ss - 1) ss
            in
                sprintf "%s and %s are" (flatten_strings ", " firsts) last
    in
        sprintf "%s v%d.%d.%d build %d [%04d-%02d-%02d]\n\
                \n\
                %s\n\
                \n\
                %s %s, %s.\n"
            title ver.Major ver.Minor ver.Build ver.Revision now.Year now.Month now.Day
            description
            (productize [product; core_title; title ]) copyright company

let usage () =
    sprintf "\n\nusage: %s <SOURCE FILENAME>\n\n%s"
        (IO.Path.GetFileName (Diagnostics.Process.GetCurrentProcess ()).MainModule.FileName)
        (credits ())

let private other s =
    filename <- s


let private infos =
  [|
    Entry.bool "unicode" (fun b -> CC.Printing.dynamic.unicode <- b) "enable/disable Unicode output" (Some CC.Printing.dynamic.unicode)
    Entry.flag "greek" (fun b -> CC.Printing.dynamic.greek_tyvars <- true) "enable greek letters for type variables"
    
    Entry.flag "interactive" (fun () -> C.mode <- C.Mode_Interactive) "enable interactive mode, possibly after interpretation of a given source file"
    Entry.flag "unit-test" (fun () -> C.mode <- C.Mode_UnitTest) "switch to unit-test mode, ignoring input files and performing all tests"

    Entry.flag "pedantic" (fun () -> C.Log.cfg.all_thresholds <- Min) "set all log thresholds to level Min"
    Entry.synonyms_no_def [|"verbose"; "v"|] Entry.flag (fun () -> C.Log.cfg.all_thresholds <- Low) "set all log thresholds to level Low"
    Entry.synonyms_no_def [|"quiet"; "q"|] Entry.flag (fun () -> C.Log.cfg.all_thresholds <- High) "set all log thresholds to level High"
    Entry.flag "silent" (fun () -> C.Log.cfg.all_thresholds <- Unmaskerable) "set all log thresholds to level Unmaskerable"
    
    Entry.string "log-file" (fun s -> CC.Log.cfg.filename <- Some s) "set log filename" CC.Log.cfg.filename
    
    Entry.string "debug-threshold" (fun s -> CC.Log.cfg.debug_threshold <- pri.Parse s) "set debug verbosity threshold" (Some CC.Log.cfg.debug_threshold)
    Entry.string "msg-threshold" (fun s -> CC.Log.cfg.msg_threshold <- pri.Parse s) "set informational messages verbosity threshold" (Some CC.Log.cfg.msg_threshold)
    Entry.string "hint-threshold" (fun s -> CC.Log.cfg.hint_threshold <- pri.Parse s) "set hint messages verbosity threshold" (Some CC.Log.cfg.hint_threshold)
    Entry.string "warn-threshold" (fun s -> CC.Log.cfg.warn_threshold <- pri.Parse s) "set warnings verbosity threshold" (Some CC.Log.cfg.warn_threshold)
    
    Entry.int "-W" Report.warnings.disable "suppress specific warning" None
    Entry.int "-H" Report.hints.disable "suppress specific hint" None
    Entry.int "+W" Report.warnings.enable "enable specific warning" None
    Entry.int "+H" Report.hints.enable "enable specific hint" None
    Entry.int "Wall" (fun n -> Report.warnings.disable_all) "activate all warnings" None
    Entry.int "Hall" (fun n -> Report.hints.disable_all) "activate all hints" None
  |] |> Array.concat

let parse () = ArgParser.Parse (infos, other, usage ())
