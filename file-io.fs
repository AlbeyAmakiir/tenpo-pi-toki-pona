0 Value fd-in
256 Constant max-line
Create line-buffer max-line 2 + allot

: open-input ( addr u -- ) r/o open-file throw to fd-in ;
: close-input ( -- ) fd-in close-file throw ;

: nextline ( -- u f ) line-buffer max-line fd-in read-line throw ;
