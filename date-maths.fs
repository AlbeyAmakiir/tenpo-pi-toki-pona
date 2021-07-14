: addtrue ( n f -- n ) 0= 1+ + ;

: leap ( n -- f )
  dup 4 mod 0= if
    dup 100 mod 0= if
      dup 400 mod 0= swap drop
    else
      drop true
    endif
  else
    drop false
  endif ;
: leapcount ( n1 n2 -- n ) \ from (inclusive) to (exclusive)
  swap 0 -rot u+do
    i leap addtrue
  loop ;
: fullyears ( n1 n2 -- n ) \ -1 means the same year
  swap - 1- ;
: monthdays ( n f -- n )
  swap dup 2 = if
    drop 28 swap addtrue
  else
    nip dup 7 > -
    2 mod 30 swap +
  endif ;
: daysbeforemonth ( f n -- n )
  1 0 -rot u+do
    over i swap monthdays +
  loop
  nip ;
: daysinyearsofar ( n-day n-month n-year -- n ) \ Includes the marked day
  leap swap daysbeforemonth + ;
: daydiffday ( n1 n2 -- n ) - ;
: daydiffmonth ( n-day1 n-month1 n-day2 n-month2 f -- n ) \ from (inclusive) to (exclusive)
  >r rot over over = if
    2drop swap daydiffday
  else
    tuck swap 1- swap 0 -rot
    u+do
      i 1+ r@ monthdays +
    loop
    >r rot swap r> -rot r@ monthdays swap - + +
  endif
  rdrop ;
: daydiffyear ( n-day1 n-month1 n-year1 n-day2 n-month2 n-year2 -- n )
  swap rot >r >r >r
  dup r@ fullyears
  dup -1 = if
    2drop r> r> r> swap rot leap daydiffmonth
  else
    1+ 365 *
    over r@ leapcount +
    r> r> r> swap rot daysinyearsofar +
    >r daysinyearsofar r> swap -
  endif ;




