s" date-maths.fs" included

: day0   ( -- n ) 25   ;
: month0 ( -- n ) 3    ;
: year0  ( -- n ) 2001 ;
: munnamakolon ( n -- f ) \ n li insa 1 en 8
  dup 3 > -
  2 mod 0= ;
: sunolonmun ( n -- n )
  dup 13 = -
  2 mod 30 swap - ;
: sunolonsike ( n -- n ) \ n li insa 1 en 8
  munnamakolon -30 * 354 + ;
: sunolonsike8 ( -- n ) 2922 ;
: sike8ensuno ( n -- n1 n2 )
  dup sunolonsike8 / swap sunolonsike8 mod ;
: sikeensunolili ( n -- n1 n2 ) \ n li lon 2923 anpa. sike li open lon 0
  1 swap 0 begin
    - over 1+ swap rot sunolonsike over over <=
  until
  drop swap 2 - swap ;
: munensuno ( n -- n1 n2 ) \ n li lon 385 anpa. mun li open lon 1
  1 swap 0 begin
    - over 1+ swap rot sunolonmun over over <=
  until
  drop swap 1 - swap ;
: sikeensuno ( n -- n1 n2 )
  sike8ensuno sikeensunolili rot 8 * rot + swap ;
: sikeenmunensuno ( n -- n1 n2 n3 )
  sikeensuno munensuno ;

: sunotangeorgian ( n-day n-month n-year -- n )
  >r >r >r day0 month0 year0 r> r> r> daydiffyear
  ; \ This one line is the *only reason* I wrote date-maths.fs
: tenpotangeorgian ( n-day n-month n-year -- n-suno n-mun n-sike )
  \ suno pini lon tenpo georgian li suno sin lon tenpo pi toki pona
  sunotangeorgian sikeenmunensuno swap rot ;



