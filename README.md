# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

✍️ Rebecca Willi

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|23.8   | 0.0.1   | Erste Dokumentation   |
|30.8   | 0.0.2     | Programmieren des Programms                                |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Ich möchte einen Number Guesser erstellen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss            |Funktional| Als Programmierer möcht ich das beim Spiel nur Zahlen eingegeben werden können, damit das Spiel nicht abstürzt.|
| 2    | Muss            |Funktional| Als Programmierer möchte ich dass der Computer eine Zahl abspeichert un diese geheim hält,damit der Spieler raten muss.|
| 3    | Muss            |Funktional| Als Spieler möcht ich Hinweise auf die gesuchte Zahl erhalten, damit ich nicht im schlimmsten Fall nicht alle Zahlen raten muss.|
| 4    | Muss            |Funktional| Als Spieler möchte ich sehen wie viele Rateversuche ich gebraucht habe, damit ich mich mit meinen Freunden vergleichen kann.|
| 5    | Kann            |Rand      | Als Spieler kann ich die anzahl Zahlen erhöhen, damit ich es mir auch schwieriger machen kann.|
| 6    | Kann            |Qualität  | Als Spieler möchte ich das keine Zahl zwei mal nacheinander kommt, damit es abwechslung beim Spiel gibt.|
| 7    | Kann            |Rand      | Als Spieler möchte ich das es ein ruhige Farbe , damit es angenehmer ist auf den Bildschirm zu schauen.|

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Das spiel wurde gestartet| Eingabe von Buchstaben| Es funktioniert nicht|
| 2.1  | Programm ist fertig| Starten des Spiels  | Zahl ausgewählt|
| 3.1  | Zahl ist eingegeben| überprüft ob es richtig ist|falsche Zahl sie ist grösser/kleiner|
| 4.1  |Raten der Zahl|Eingabe richtiger Zahl| gebraucht wurden ... Versuche|
| 5.1  |Zahlen von 1-100| erhöhen auf 1000| Zahlen von 1-1000 können eraten werden|
| 6.1  |Bereits eine Zahl ausgesuch| Neuer versuch beim Spiel| Andere Zahl ist richtig|
| 7.1  |Spiel ist noch nicht offen| spiel öffnen| keine leuchtende Farbe als Hintergrund|

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 6.9   |Willi Rebecca|Programmieung eingeben nur von Zahlen  |45 Minuten|
| 2.A  | 6.9   |Willi Rebecca|Programmierung speichern der Zahl im Hintergrund |45 Minuten|
| 3.A  | 6.9   |Willi Rebecca|Programmierung geben von  Hinweisen auf die Zahl |45 Minuten|
| 4.A  | 6.9   |Willi Rebecca|Programmierung  zählen der Versuche |45 Minuten|
| 5.A  | 6.9   |Willi Rebecca|Programmierung erhöhen und vermindern der Zahlen|45 Minuten|
| 6.A  | 6.9   |Willi Rebecca|Programmierung wählen Unterschiedliche Zahlen |45 Minuten|
| 7.A  | 6.9   |Willi Rebecca|Programmierung Hintergrund|45 Minuten|
Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Erst Programmieren des Zahlengenrators
   

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| 2.A  |30.8.2022|Rebecca Willi|45 Minuten |   10 Minuten      |
|3.A   | 30.8.2022|Rebecca Willi|45 Minuten|   60 Minuten      |
|4.A   |
|5.A   |06.09.2022|Rebecca Willi|45 Minuten| 75 Minuten
|6.A   |
|7.A   | 30.8.2022| Rebecca Willi | 45 Minuten| 15 Minuten|
✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
