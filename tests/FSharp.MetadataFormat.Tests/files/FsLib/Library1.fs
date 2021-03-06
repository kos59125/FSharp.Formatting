﻿namespace FsLib

/// Union sample
type Union = 
  /// Hello of int
  | Hello of int
  /// World of string and int
  | World of string * int

/// Record sample
type Record = 
  { /// This is name
    Name : string
    /// This is age
    Age : int }
  /// Additional member
  member x.Foo = 0
