# Opret en bestilling

## Forretningsbehov

ByteBites skal kunne registrere nye bestillinger hurtigt og korrekt, så medarbejderne kan se, hvad der skal tilberedes.

## User story

Som medarbejder vil jeg kunne oprette en bestilling med ret og antal, så køkkenet kan tilberede det rigtige.

## Acceptkriterier

- Brugeren kan vælge en af de tre gyldige retter.
- Brugeren kan indtaste et positivt antal.
- Bestillingen får et unikt id.
- En ny bestilling får status `MODTAGET`.
- Bestillingen vises efter oprettelse.
- Ugyldig ret eller ugyldigt antal afvises med en forståelig besked.
- Programmet crasher ikke ved forkert input.
- Der kan højst gemmes ti bestillinger.

## Afgrænsning

Bestillinger gemmes kun i hukommelsen. Issuet omfatter ikke database, betaling, webgrænseflade eller ændring af en bestillings status.

## Forslag til manuelle test

| Test | Input eller handling | Forventet resultat |
|---|---|---|
| Gyldig bestilling | Gyldig ret og antal `2` | Bestillingen vises med unikt id og `MODTAGET` |
| Ugyldig ret | Et valg uden for menuen | Fejlbesked, og programmet fortsætter |
| Antal nul | `0` | Bestillingen afvises |
| Negativt antal | `-1` | Bestillingen afvises |
| Tekst som antal | Eksempelvis `to` | Programmet crasher ikke |
| Maksimum | Forsøg på bestilling nummer 11 | Bestillingen afvises med en besked |

## Definition of done

- Acceptkriterierne er kontrolleret.
- Koden er forstået og gennemgået.
- Manuelle test er dokumenteret i pull requesten.
- Den automatiske kontrol er grøn.
- Pull requesten er reviewet og merget.

## Labels

`feature`, `programmering`, `systemudvikling`, `teknologi`
