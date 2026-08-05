# Markér en bestilling som klar

## Forretningsbehov

Når køkkenet har tilberedt en bestilling, skal medarbejderne kunne markere den som klar til udlevering.

## User story

Som medarbejder vil jeg kunne markere en bestilling som klar, så det er tydeligt, at den kan udleveres.

## Acceptkriterier

- Brugeren kan indtaste et bestillings-id.
- En bestilling med status `MODTAGET` kan ændres til `KLAR`.
- Den opdaterede bestilling og status vises.
- Et id, der ikke findes, giver en forståelig besked.
- Programmet crasher ikke ved forkert input.

## Afgrænsning

Issuet omfatter kun statusskiftet fra `MODTAGET` til `KLAR`. Det omfatter ikke betaling, udlevering eller database.

## Forslag til manuelle test

| Test | Input eller handling | Forventet resultat |
|---|---|---|
| Eksisterende bestilling | Id på en bestilling med `MODTAGET` | Status ændres til `KLAR` og vises |
| Ukendt id | Et id, der ikke findes | Forståelig besked, og programmet fortsætter |
| Forkert input | Tekst i stedet for et id | Programmet crasher ikke |

## Definition of done

- Acceptkriterierne er kontrolleret.
- Testresultaterne er dokumenteret.
- Koden er reviewet.
- Den automatiske kontrol er grøn.
- Pull requesten er merget.

## Labels

`feature`, `programmering`, `systemudvikling`
