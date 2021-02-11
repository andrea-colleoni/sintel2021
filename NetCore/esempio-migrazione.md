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

## Business layer

- Rifattorizzare le classi di business per ricevere le dipendenze dall'injector di Net Core
- Ripristinare le dependency del progetto legacy e di tutto lo stack soprastante

## Testing



## Controllers

- using using Microsoft.AspNetCore.Mvc;
- ApiController => Attribute
- Controller : ControllerBase
- private SiDb db = new SiDb(); => private SiDb db;
- Dispose() => eliminare
- IHttpActionResult => ActionResult
- [ResponseType(typeof({Type}))] => ActionResult<{Type}>
- HttpStatusCode.NoContent => StatusCodes.Status204NoContent

## Links

- [Jwt Auth in Net COre 5](https://github.com/dotnet-labs/JwtAuthDemo)
- https://docs.microsoft.com/it-it/dotnet/standard/net-standard