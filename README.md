# Multithread_Race_Condition
Race State created and resolved

#Wat is multithreading?
**Multithreading is de mogelijk van een systeem of programma om meerdere threads the gebruiken**

*bron: http://www.ming-automatisering.nl/Definities/definitiesm.htm*

#Wanneer gebruik je meerdere threads?
**als een programma of systeem meerdere dingen tegelijk moet doen**

*bron: https://nl.wikipedia.org/wiki/Thread_(informatica)*

#Wat zijn drie veel voorkomende problemen bij mutithreaded applications? Waardoor ontstaan ze?
**Race conditie wanneer meerdere threads tegelijk een stuk geheugen willen aanpassen**
**Deadlock = wanneer meerdere threads op andere wachten inclusief de actieve thread dus de threads zitten vast in een cirkel van wachten** 
**Clobbering = wanneer meerdere threads geheugen van elkaar overschrijven**

*bron: https://en.wikipedia.org/wiki/Clobbering*
*bron: https://en.wikipedia.org/wiki/Deadlock*
*bron: https://en.wikipedia.org/wiki/Race_condition*


#Hoe wordt het onderdeel genoemd waar objecten in het geheugen worden geplaatst?
**objecten worden opgeslagen in de HEAP.**

#Hoe is dit verschillend in een multithreaded application?
**Volgens mij worden de objecten gemaakt in threads nog steeds in de algehele HEAP opgeslagen.**

#Hoe wordt het onderdeel genoemd waar methoden worden uitgevoerd en primitive types in het geheugen worden geplaatst?
**Methoden en primitieve types worden in de Stack geplaats.**

#Hoe is dit verschillend in een multithreaded application?
**alle methoden die in een thread worden aangeroepen worden bovenop de Stack frames gezet.**
*bron: https://blog.usejournal.com/java-multithreading-part-1-ec0c42bbead6*


#Wat is in dit kader een racing condition? Hoe zou je dit kunnen voorkomen?
**Racing conditie is een staat waarin meerdere threads tegelijk een stuk geheugen willen aanpassen en dan is het aan het systeem om te bepalen welke thread als eerste en welke als tweede.
Dit kan je voorkomen door LOCK te gebruiken dat wil zeggen dat het geheugen wordt afgesloten zodra een thread bezig is zodat de andere thread er niet bij kan.**