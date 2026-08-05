# Vis antal ventende bestillinger

## Forretningsbehov

Medarbejderne skal hurtigt kunne se, hvor mange bestillinger køkkenet endnu mangler at tilberede.

## User story

Som medarbejder vil jeg kunne se antallet af ventende bestillinger, så jeg kan vurdere køkkenets aktuelle arbejdspres.

## Acceptkriterier

- Programmet tæller bestillinger med status `MODTAGET`.
- Bestillinger med status `KLAR` eller `ANNULLERET` medregnes ikke.
- Programmet viser `0`, hvis der ikke er ventende bestillinger.
- Resultatet vises med en forståelig tekst.

## Afgrænsning

Issuet viser kun et aktuelt antal. Det omfatter ikke statistik, historik, svartider eller database.

## Forslag til manuelle test

| Test | Input eller handling | Forventet resultat |
|---|---|---|
| Ingen bestillinger | Vis antal ved programstart | `0` vises |
| To modtagne | Opret to bestillinger med `MODTAGET` | `2` vises |
| Blandede statusser | Brug `MODTAGET`, `KLAR` og `ANNULLERET` | Kun `MODTAGET` tælles med |

## Definition of done

- Acceptkriterierne er kontrolleret.
- Testresultaterne er dokumenteret.
- Koden er reviewet.
- Den automatiske kontrol er grøn.
- Pull requesten er merget.

## Labels

`feature`, `programmering`, `it-forretning`
