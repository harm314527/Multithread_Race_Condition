# Multithread_Race_Condition
Race State created and resolved

#Wat is multithreading?

**Multithreading is de mogelijkheid van een systeem of programma om meerdere threads the gebruiken.**

*bron: http://www.ming-automatisering.nl/Definities/definitiesm.htm*

#Wanneer gebruik je meerdere threads?

**als een programma of systeem meerdere dingen tegelijk moet doen.**

*bron: https://nl.wikipedia.org/wiki/Thread_(informatica)*

#Wat zijn drie veel voorkomende problemen bij mutithreaded applications? Waardoor ontstaan ze?

**Race conditie = Wanneer meerdere threads tegelijk een stuk geheugen willen aanpassen.**

**Deadlock = Wanneer meerdere threads op andere wachten inclusief de actieve thread dus de threads zitten vast in een cirkel van wachten.** 

**Clobbering = Wanneer meerdere threads geheugen van elkaar overschrijven.**

*bron: https://en.wikipedia.org/wiki/Clobbering*

*bron: https://en.wikipedia.org/wiki/Deadlock*

*bron: https://en.wikipedia.org/wiki/Race_condition*


#Hoe wordt het onderdeel genoemd waar objecten in het geheugen worden geplaatst?

**objecten worden opgeslagen in de HEAP.**

#Hoe is dit verschillend in een multithreaded application?

**Volgens mij worden de objecten gemaakt in threads nog steeds in de algehele HEAP opgeslagen.**

*bron: https://www.cs.ru.nl/E.Poll/talks/p3_threads.pdf*

#Hoe wordt het onderdeel genoemd waar methoden worden uitgevoerd en primitive types in het geheugen worden geplaatst?

**Methoden en primitieve types worden in de Stack geplaatst.**

#Hoe is dit verschillend in een multithreaded application?

**all threads krijgen een eigen Stack.**

*bron: https://www.cs.ru.nl/E.Poll/talks/p3_threads.pdf*


#Wat is in dit kader een racing condition? Hoe zou je dit kunnen voorkomen?

**Racing conditie is een staat waarin meerdere threads tegelijk een stuk geheugen willen aanpassen en dan is het aan het systeem om te bepalen in welke volgorde de threads bij dat stuk geheugen kunnen waardoor het vaak zo is dat de uitkomst van die multithreaded operatie steeds verschillend is.
Dit kan je voorkomen door LOCK te gebruiken dat wil zeggen dat het geheugen wordt afgesloten zodra een thread bezig is zodat de andere threads er niet bij kunnen.**