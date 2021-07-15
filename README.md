# tenpo pi toki pona
tenpo pi mun suno pi toki pona tawa linja toki ilo. mi kepeken e ilo "Gforth" tan ni: ni pilin pona tawa mi. mi sin lili tawa ilo "Gforth".

nasin ni li [tan lipu Leti ni](https://www.reddit.com/r/tokipona/comments/dr378j/lunisolar_calendar_for_toki_pona_done/).

nimi mun [tan lipu Leti ni](https://www.reddit.com/r/tokipona/comments/oikpr8/toki_tan_a_creation_story_in_toki_pona_inspired/).

### toki Inli (English)
A terminal-based toki pona lunisolar calendar, written in Gforth because I felt like it. I'm kinda' new to Gforth.

Based on the original post described [in this reddit thread](https://www.reddit.com/r/tokipona/comments/dr378j/lunisolar_calendar_for_toki_pona_done/).

With month names [from this reddit thread](https://www.reddit.com/r/tokipona/comments/oikpr8/toki_tan_a_creation_story_in_toki_pona_inspired/).

## nasin kepeken (Usage)
ni li kepeken ilo "[Gforth](https://gforth.org/)". mi kepeken nanpa `0.7.3` ona taso.

(English) This tool uses [Gforth](https://gforth.org/). I've only been using version `0.7.3`.

```
$ gforth tenpo-pi-suno-mun.fs -e tokietenponi -e bye
tenpo pi toki pona
------------------
tenpo sike  20 
tenpo mun   Telo
tenpo suno  9 
------------------
```

## nasin lukin pona anu ike (Testing)

```
$ gforth tenpo-pi-suno-mun-test.fs -e runall -e bye

~~~ Testing tenpo-pi-suno-mun.fs ~~~
Test word munnamakolon:   Passed
Test word sunotangeorgian:   Passed
Test word beforesunset:   Passed
[... en sama]
```
mi sona e ni: sitelen ni li pona lili. :sweat_smile:

(English) I know it's not great test code. :sweat_smile:

## mi ken ala ken pana pali tawa ni? (Can I help?)

a! sina pona! taso, mi sona ala. ni li pali lili mi. tan ni, mi wile pana tawa sina ale e ona. taso, sina wile pali lon ona la, ken la mi lukin e ni. (mi toki e "ken la" tan ni: tenpo ale la, mi jo e wawa lili. :sweat_smile: )

(English) Oh, that's nice of you to offer! I'm not really sure, since this is just a small project I wanted to share. Still, if you write something for it, I might give it a look over. (I say "might" because I am disabled and have little energy. :sweat_smile: )
