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

: nimimun ( n -- c-addr u )
    case
      1 of s" Wan" endof
      2 of s" Kon" endof
      3 of s" Seli" endof
      4 of s" Ma" endof
      5 of s" Telo" endof
      6 of s" Mama" endof
      7 of s" Kasi" endof
      8 of s" Pipi" endof
      9 of s" Kala" endof
      10 of s" Akesi" endof
      11 of s" Waso" endof
      12 of s" Soweli" endof
      13 of s" Namako" endof
    endcase ;

: sunotangeorgian ( n-day n-month n-year -- n )
  >r >r >r day0 month0 year0 r> r> r> daydiffyear
  ; \ This one line is the *only reason* I wrote date-maths.fs
: tenpotangeorgian ( f n-day n-month n-year -- n-suno n-mun n-sike )
  \ suno weka lon tenpo georgian li suno sin lon tenpo pi toki pona
  sunotangeorgian swap + sikeenmunensuno swap rot ;
: beforesunset ( n-sec n-min n-hour -- f )
  \ For now, just making it past 6pm. Theoretically, lonlat+date, I could solve. But eh...
  18 < nip nip ;

: tenponi ( -- n-suno n-mun n-sike )
  time&date >r >r >r beforesunset r> r> r> tenpotangeorgian ;
: tokietenpo ( n-suno n-mun n-sike -- )
  s" tenpo pi toki pona" type cr
  s" ------------------" type cr
  s" tenpo sike  " type . cr
  s" tenpo mun   " type nimimun type cr
  s" tenpo suno  " type . cr
  s" ------------------" type cr ;
: tokietenponi ( -- ) tenponi tokietenpo ;



