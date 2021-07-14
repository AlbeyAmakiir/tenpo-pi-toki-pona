s" date-maths.fs" included

: testleap
  s" Test word leap: " type
  try
    assert( 1900 leap 0= )
    assert( 1999 leap 0= )
    assert( 2000 leap 0<> )
    assert( 2001 leap 0= )
    assert( 2002 leap 0= )
    assert( 2003 leap 0= )
    assert( 2004 leap 0<> )
    assert( 2005 leap 0= )
    assert( 2100 leap 0= )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testleapcount
  s" Test word leapcount: " type
  try
    assert( 1999 2005 leapcount 2 = )
    assert( 2001 2002 leapcount 0= )
    assert( 2001 2001 leapcount 0= )
    assert( 2001 2000 leapcount 0= )
    assert( 2004 2005 leapcount 1 = )
    assert( 2004 2004 leapcount 0= )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testfullyears
  s" Test word fullyears: " type
  try
    assert( 2000 2005 fullyears 4 = )
    assert( 2000 2002 fullyears 1 = )
    assert( 2000 2001 fullyears 0= )
    assert( 2000 2000 fullyears -1 = )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testmonthdays
  s" Test word monthdays: " type
  try
    assert( 1 false monthdays 31 = )
    assert( 1 true monthdays 31 = )
    assert( 2 false monthdays 28 = )
    assert( 2 true monthdays 29 = )
    assert( 4 false monthdays 30 = )
    assert( 4 true monthdays 30 = )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testdaysbeforemonth
  s" Test word daysbeforemonth: " type
  try
    assert( false 1 daysbeforemonth 0= )
    assert( true 1 daysbeforemonth 0= )
    assert( false 2 daysbeforemonth 31 = )
    assert( true 2 daysbeforemonth 31 = )
    assert( false 3 daysbeforemonth 59 = )
    assert( true 3 daysbeforemonth 60 = )
    assert( false 12 daysbeforemonth 334 = )
    assert( true 12 daysbeforemonth 335 = )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testdaysinyearsofar
  s" Test word daysinyearsofar: " type
  try
    assert( 1 1 2020 daysinyearsofar 1 = )
    assert( 30 1 2020 daysinyearsofar 30 = )
    assert( 5 3 2021 daysinyearsofar 64 = )
    assert( 5 3 2020 daysinyearsofar 65 = )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testdaydiffmonth
  s" Test word daydiffmonth: " type
  try
    assert( 1 5 1 6 false daydiffmonth 31 = )
    assert( 1 5 10 6 false daydiffmonth 40 = )
    assert( 30 4 1 6 false daydiffmonth 32 = )
    assert( 31 5 1 7 false daydiffmonth 31 = )
    assert( 30 4 1 7 false daydiffmonth 62 = )
    assert( 30 6 1 9 false daydiffmonth 63 = )
    assert( 1 5 10 5 false daydiffmonth 9 = )
    assert( 1 5 1 5 false daydiffmonth 0= )
    assert( 20 5 10 6 false daydiffmonth 21 = )
    assert( 20 5 10 6 true daydiffmonth 21 = )
    assert( 20 2 10 3 false daydiffmonth 18 = )
    assert( 20 2 10 3 true daydiffmonth 19 = )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testdaydiffyear
  s" Test word daydiffyear: " type
  try
    assert( 1 1 2020 1 1 2020 daydiffyear 0= )
    assert( 1 1 2020 2 1 2020 daydiffyear 1 = )
    assert( 1 1 2020 1 2 2020 daydiffyear 31 = )
    assert( 1 4 2020 1 5 2020 daydiffyear 30 = )
    assert( 1 2 2019 1 3 2019 daydiffyear 28 = )
    assert( 1 2 2020 1 3 2020 daydiffyear 29 = )
    assert( 1 1 2019 1 1 2020 daydiffyear 365 = )
    assert( 1 1 2020 1 1 2021 daydiffyear 366 = )
    assert( 31 12 2019 1 1 2021 daydiffyear 367 = )
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: testtemplate
  s" Test word <template>: " type
  try
    s"   Passed" type cr
  endtry-iferror
    s" --- FAILED ---" type cr
  then ;

: runall
  cr s" ~~~ Testing date-maths.fs ~~~" type cr
  testleap testleapcount testfullyears
  testmonthdays testdaysbeforemonth testdaysinyearsofar
  testdaydiffmonth testdaydiffyear
  cr ;

