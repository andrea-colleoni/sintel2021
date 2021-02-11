# Esempio migrazione di Si2020

## Scorporamento del model

- Abbiamo scorporato il modello dati EF in un progetto Net Std
- Ripristinato le dependency del progetto EF legacy e di tutto lo stack soprastante

## Librerie comuni

- Verificare la possibilità di migrare librerie comuni sviluppate internamente in Net Std

## Nuovo EF Core

- Ripristino di tutte le dependencies del progetto EF legacy
  - Verificare la disponibilità delle dipendenze utilizzate nel progetto legacy con Net Core
- Migrare le configurazioni: config => json
- Migrare il context EF
 - using System.Data.Entity; => using Microsoft.EntityFrameworkCore;
 - DbModelBuilder => ModelBuilder
   - HasRequired => HasOne (ed eventualmente altre differenze)
 - Costruttore context => argomento DbContextOptions<{contextClass}> options
   - base(options)
 - Attributi custom utilizzati nel modello
 - Utilizzo di nuove funzioni ove possibile (e.g. EF.Functions.TextSearch())