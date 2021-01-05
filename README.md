# CodingChallenge for get in IT and BWI (IT für Deutschland)
 Simulator zur Berechnung der optimalen Verteilung von Hardware (inkl. Gesamtnutzen) in X Transportern
 
# Informationen
 Die Releases (also .EXE Datei als Programm zum Ausführen) sind hier zu finden: https://github.com/nflug/CodingChallenge/releases

# Bedienung
 1. Die neuste Version auf der Releases-Seite herunterladen und entpacken. (https://github.com/nflug/CodingChallenge/releases/tag/1.0.0)
 2. CodingChallenge.exe starten (eventuell mit Administrationsrechten & deaktiviertem Antivirus-Programm (Aufgrund von NuGet-Packages wird dieses manchmal getriggert)).
 2. JSON Datei auswählen (oben rechts), welche die Daten für Hardware und Transporter enthält (befindet sich im Release-Ordner).
 3. Die Daten sind nun geladen und können in der Tabelle eingesehen werden.
 
 Sollte es Probleme geben, einfach per E-Mail anschreiben oder auf GITHub ein Issue erstellen.

# Begründung & Erklärung
Für die Lösung des Problems, der optimalen Verteilung der Hardware, habe ich mich für den Ansatz des `Rucksackproblems` (engl. Knapsack Problem, https://de.wikipedia.org/wiki/Rucksackproblem) entschieden, da dieses passend auf die Aufgabe zutrifft, ein Raum mit bestimmter Größe soll optimal mit passenden Elementen von bestimmter Größe gefüllt werden. Hier bei wird der sogenannte `Greedy-Algorithmus` angewandt (https://de.wikipedia.org/wiki/Greedy-Algorithmus). Diesen habe ich benutzt um, wie auf Wikipedia beschrieben, `das beste Ergebnis` zu erreichen. Kurz erklärt, der Algorithmus versucht durch eine `Bewertungsfunktion`, schnellst möglich und optimal das beste Ergebnis zu erzielen.

# Die Aufgabe
 Die Nutzer in Bonn benötigen die verschiedenen Notebooks, Telefone und Tablets mit unterschiedlicher Dringlichkeit. Daher ist für jeden Gerätetyp ein Nutzwert ermittelt worden. Ziel ist es, mit der Auslieferung der ersten Fahrt einen möglichst hohen kumulierten Nutzen zu erzielen.

 Für die Fahrt an den Bonner Standort stehen Dir 2 Transporter zur Verfügung. Entwickle einen Algorithmus, um die beiden Transporter optimal für die erste (einmalige) Fahrt zu beladen. Beachte hierbei die Ladekapazität der Transporter sowie die unterschiedlichen Gewichte der Hardware und den Bedarf am Standort Bonn. Ergebnis soll eine optimale Ladeliste sein. 
