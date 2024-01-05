Použité návrhové vzory:

Singleton
    pro manipulaci s grafikou (centrování, rozdělování částí...) je vytvořen objekt Formater
    pro zamezení duplikátu objektu, který je určen pouze pro manipulaci a nemá žádné atributy byla třída Formater vytvořena jako Singleton

    to samé pro objekt WindowManager, který je přiřazen více objektům, ovšem jeho funkce nezáleží na tom,
    komu patří. zamezení duplikátu

Strategy
    pro vykreslování grafiky do terminálu je vytvořen objekt WindowsManager,
    který nese atribut, jakého typu chce vytvořit okno
    tento typ je interface IWindowDisplay, ze kterého se odvíjí třídy, které mají metodu DisplayWindow
    U každé třídy je rozdílně implementovaná metoda DisplayWindow

    WindowManager nese WindowDisplay, který volá jeho, aby zavolal svou funkci

Facade
    objekt Game funguje jako fasáda
    uchovává jiné objekty, které mají vlastní metody a volají je





TO-do

Vychod ze dveri, zobrazeni mapy
Jit do krovi, zastavi me Oak a musim ho nasledovat do jeho Labu
V jeho labu je oakspeech, kde si me necha vybrat Pokemona
Muj rival si vezme taky Pokemona
muj rival me zastavi a mam prvni battle s pokemonem

    