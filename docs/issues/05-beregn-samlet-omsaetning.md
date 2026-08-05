# Beregn samlet omsætning

Dette issue er en frivillig ekstraopgave.

## Forretningsbehov

ByteBites vil kunne se den samlede omsætning for de bestillinger, der ikke er annulleret.

## User story

Som ansvarlig for foodtrucken vil jeg kunne se den samlede omsætning, så jeg får et hurtigt overblik over salget.

## Acceptkriterier

- Hver af de tre retter har en fast pris.
- Programmet beregner summen af pris gange antal.
- Annullerede bestillinger medregnes ikke.
- Programmet viser `0`, hvis der ikke er relevante bestillinger.
- Beløbet vises med en forståelig tekst.

## Afgrænsning

Issuet omfatter ikke betaling, moms, rabatter, valutaomregning, statistik eller database.

## Forslag til manuelle test

| Test | Input eller handling | Forventet resultat |
|---|---|---|
| Ingen bestillinger | Vis omsætning ved programstart | `0` vises |
| Én bestilling | Opret en ret med antal `2` | Retpris gange `2` vises |
| Flere bestillinger | Opret forskellige retter og antal | Den korrekte sum vises |
| Annulleret bestilling | Annullér én af bestillingerne | Den annullerede bestilling medregnes ikke |

## Definition of done

- Acceptkriterierne er kontrolleret.
- Testresultaterne er dokumenteret.
- Koden er reviewet.
- Den automatiske kontrol er grøn.
- Pull requesten er merget.

## Labels

`feature`, `programmering`, `it-forretning`
