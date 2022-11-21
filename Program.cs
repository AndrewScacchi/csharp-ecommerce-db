//Considerando che:
//ci sono clienti che effettuano ordini.
//Un ordine viene preparato da un dipendente.
//Un ordine ha associato uno o più pagamenti (considerando eventuali tentativi falliti)

//Realizzate le seguenti funzionalità
//inserite 10 prodotti all’avvio del programma (i prodotti non devono essere inseriti in caso si riavvi l’applicazione)
//quando l’applicazione si avvia chiede se l’utente è un dipendete o un cliente
//se è un dipendente potrà eseguire CRUD sugli ordini
//se è un cliente potrà acquistare degli ordini
//simulate randomicamente l’esito di un acquisto (status = ok | status = ko)
//Bonus
//Il dipendente deve poter spedire gli ordini acquistati per cui il pagamento è andato a buon fine.

using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

EcommerceDbContext db = new EcommerceDbContext();