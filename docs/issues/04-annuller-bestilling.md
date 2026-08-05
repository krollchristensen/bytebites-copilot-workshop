# Annullér en bestilling

## Forretningsbehov

Hvis en kunde fortryder, skal medarbejderne kunne annullere bestillingen, så køkkenet ikke tilbereder den.

## User story

Som medarbejder vil jeg kunne annullere en bestilling, så en bestilling, der ikke længere skal laves, får den korrekte status.

## Acceptkriterier

- Brugeren kan indtaste et bestillings-id.
- En eksisterende bestilling kan ændres til status `ANNULLERET`.
- Den opdaterede bestilling og status vises.
- Et id, der ikke findes, giver en forståelig besked.
- En allerede annulleret bestilling giver en forståelig besked.
- Programmet crasher ikke ved forkert input.

## Afgrænsning

Issuet omfatter kun ændring af status. Bestillingen slettes ikke, og der håndteres ikke tilbagebetaling eller database.

## Forslag til manuelle test

| Test | Input eller handling | Forventet resultat |
|---|---|---|
| Eksisterende bestilling | Id på en aktiv bestilling | Status ændres til `ANNULLERET` og vises |
| Ukendt id | Et id, der ikke findes | Forståelig besked, og programmet fortsætter |
| Allerede annulleret | Samme id annulleres igen | Forståelig besked uden statusskift |
| Forkert input | Tekst i stedet for et id | Programmet crasher ikke |

## Definition of done

- Acceptkriterierne er kontrolleret.
- Testresultaterne er dokumenteret.
- Koden er reviewet.
- Den automatiske kontrol er grøn.
- Pull requesten er merget.

## Labels

`feature`, `programmering`, `systemudvikling`
