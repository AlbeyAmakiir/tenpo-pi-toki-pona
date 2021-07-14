s" tenpo-pi-suno-mun.fs" included

: testmunnamakolon
  s" Test word munnamakolon: " type
  try
    assert( 1 munnamakolon 0= )
    assert( 2 munnamakolon 0<> )
    assert( 3 munnamakolon 0= )
    assert( 4 munnamakolon 0= )
    assert( 5 munnamakolon 0<> )
    assert( 6 munnamakolon 0= )
    assert( 7 munnamakolon 0<> )
    assert( 8 munnamakolon 0= )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testsunolonmun
  s" Test word sunolonmun: " type
  try
    assert( 1 sunolonmun 29 = )
    assert( 2 sunolonmun 30 = )
    assert( 3 sunolonmun 29 = )
    assert( 4 sunolonmun 30 = )
    assert( 11 sunolonmun 29 = )
    assert( 12 sunolonmun 30 = )
    assert( 13 sunolonmun 30 = )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testsunolonsike
  s" Test word sunolonsike: " type
  try
    assert( 1 sunolonsike 354 = )
    assert( 2 sunolonsike 384 = )
    assert( 3 sunolonsike 354 = )
    assert( 4 sunolonsike 354 = )
    assert( 5 sunolonsike 384 = )
    assert( 6 sunolonsike 354 = )
    assert( 7 sunolonsike 384 = )
    assert( 8 sunolonsike 354 = )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testsike8ensuno
  s" Test word sike8ensuno: " type
  try
    assert( 0 sike8ensuno 0= swap 0= and )
    assert( 100 sike8ensuno 100 = swap 0= and )
    assert( 2921 sike8ensuno 2921 = swap 0= and )
    assert( 2922 sike8ensuno 0= swap 1 = and )
    assert( 2923 sike8ensuno 1 = swap 1 = and )
    assert( 3000 sike8ensuno 78 = swap 1 = and )
    assert( 7416 sike8ensuno 1572 = swap 2 = and )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testsikeensunolili
  s" Test word sikeensunolili: " type
  try
    assert( 1 sikeensunolili 1 = swap 0= and )
    assert( 100 sikeensunolili 100 = swap 0= and )
    assert( 353 sikeensunolili 353 = swap 0= and )
    assert( 354 sikeensunolili 354 = swap 0= and )
    assert( 355 sikeensunolili 1 = swap 1 = and )
    assert( 2921 sikeensunolili 353 = swap 7 = and )
    assert( 2922 sikeensunolili 354 = swap 7 = and )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testmunensuno
  s" Test word munensuno: " type
  try
    assert( 1 munensuno 1 = swap 1 = and )
    assert( 20 munensuno 20 = swap 1 = and )
    assert( 28 munensuno 28 = swap 1 = and )
    assert( 29 munensuno 29 = swap 1 = and )
    assert( 30 munensuno 1 = swap 2 = and )
    assert( 58 munensuno 29 = swap 2 = and )
    assert( 59 munensuno 30 = swap 2 = and )
    assert( 60 munensuno 1 = swap 3 = and )
    assert( 384 munensuno 30 = swap 13 = and )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testsikeensuno
  s" Test word sikeensuno: " type
  try
    assert( 0 sikeensuno 0= swap 0= and )
    assert( 100 sikeensuno 100 = swap 0= and )
    assert( 2921 sikeensuno 353 = swap 7 = and )
    assert( 2922 sikeensuno 0= swap 8 = and )
    assert( 2923 sikeensuno 1 = swap 8 = and )
    assert( 3000 sikeensuno 78 = swap 8 = and )
    assert( 7416 sikeensuno 126 = swap 20 = and )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testsikeenmunensuno
  s" Test word sikeenmunensuno: " type
  try
    assert( 1 sikeenmunensuno 1 = -rot 1 = -rot 0= and and )
    assert( 29 sikeenmunensuno 29 = -rot 1 = -rot 0= and and )
    assert( 30 sikeenmunensuno 1 = -rot 2 = -rot 0= and and )
    assert( 59 sikeenmunensuno 30 = -rot 2 = -rot 0= and and )
    assert( 60 sikeenmunensuno 1 = -rot 3 = -rot 0= and and )
    assert( 354 sikeenmunensuno 30 = -rot 12 = -rot 0= and and )
    assert( 355 sikeenmunensuno 1 = -rot 1 = -rot 1 = and and )
    assert( 738 sikeenmunensuno 30 = -rot 13 = -rot 1 = and and )
    assert( 739 sikeenmunensuno 1 = -rot 1 = -rot 2 = and and )
    assert( 7416 sikeenmunensuno 8 = -rot 5 = -rot 20 = and and )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testsunotangeorgian
  s" Test word sunotangeorgian: " type
  try
    assert( 26 3 2001 sunotangeorgian 1 = )
    assert( 14 7 2021 sunotangeorgian 7416 = )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testtenpotangeorgian
  s" Test word tenpotangeorgian: " type
  try
    assert( 26 3 2001 tenpotangeorgian 0= -rot 1 = -rot 1 = and and )
    assert( 3 11 2019 tenpotangeorgian 18 = -rot 8 = -rot 9 = and and )
    assert( 21 3 2020 tenpotangeorgian 18 = -rot 12 = -rot 30 = and and )
    assert( 22 3 2020 tenpotangeorgian 19 = -rot 1 = -rot 1 = and and )
    assert( 14 7 2021 tenpotangeorgian 20 = -rot 5 = -rot 8 = and and )
    \ Sunset on the 14th of June, 2021 is the beginning of toki pona year 20, month 5, day 8
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testtemplate
  s" Test word <template>: " type
  try
    assert( true )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: runall
  cr s" ~~~ Testing tenpo-pi-suno-mun.fs ~~~" type cr
  testmunnamakolon testsunolonmun testsunolonsike
  testsike8ensuno testsikeensunolili testmunensuno
  testsikeensuno testsikeenmunensuno
  testsunotangeorgian testtenpotangeorgian
  cr ;

