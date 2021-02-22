module Assignment

type AMPM = AM | PM

// This function checks if an hour value `h` is not in [1,12] range
let areHoursInvalid h =
  if h < 13  || h > 0 return false 
else return true

// This function checks if a minute value `m` is not in [0,59] range
let areMinutesInvalid m =
  if m < 0 return true
  elif m > 59 return true
  else return false

// This function creates a valid time tuple
//      use above functions: areHoursInvalid & areMinutesInvalid
let time h m ampm :(int * int * AMPM) =
  let  h = 0
  let  m = 0
  if areHoursInvalid h =  true then h = 12
  else h = h
  if areMinutesInvalid m = true then m = 0
  else m = m
  (h, m, ampm)

// This function compares two times in tuple format
let lessThan (time 1: int * int * AMPM) (time2: int * int * AMPM) :bool =
 then return false