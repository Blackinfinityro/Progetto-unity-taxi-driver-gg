# Taxi Rush

Taxi Rush è un endless runner arcade sviluppato con Unity in cui il giocatore controlla un taxi all'interno di una città generata dinamicamente. L'obiettivo è evitare il traffico, sopravvivere il più a lungo possibile e ottenere il punteggio più alto.

## Descrizione

Il gioco propone una sfida continua in cui il giocatore deve schivare i veicoli presenti sulla strada mentre la difficoltà aumenta progressivamente. 

Il progetto è stato realizzato utilizzando Unity e C#, con particolare attenzione alla modularità del codice, alla gestione delle prestazioni e all'esperienza utente.

## Funzionalità

### Sistema di guida

* Controllo del veicolo semplice e immediato.
* Movimento fluido e responsivo.
* Gestione delle collisioni e della fine della partita.

### Generazione procedurale

* Generazione dinamica delle strade.
* Creazione automatica degli elementi necessari al gameplay.
* Rimozione degli oggetti non più utilizzati per ottimizzare le prestazioni.

### Sistema di traffico

* Veicoli generati automaticamente.
* Ostacoli variabili durante la partita.
* Incremento progressivo della difficoltà.

### Sistema di punteggio

* Incremento continuo del punteggio durante la partita.
* Aggiornamento animato dell'interfaccia utente.
* Gestione del punteggio personale.

### Audio

* Riproduzione della musica di sottofondo.
* Cambio dinamico delle tracce.
* Supporto agli effetti sonori di gioco.

### Gestione delle scene

* Video introduttivo.
* Possibilità di saltare l'introduzione.

### Interfaccia utente

* Menu principale.
* Menu di pausa.
* Schermata di Game Over.
* Visualizzazione del punteggio in tempo reale.

## Controlli

| Azione             | Tasto                |
| ------------------ | -------------------- |
| Muovi a sinistra   | A / Freccia Sinistra |
| Muovi a destra     | D / Freccia Destra   |
| Pausa              | ESC                  |
| Salta introduzione | Qualsiasi tasto      |

## Struttura del progetto

```text
Assets/
├── Scripts/
├── Scenes/
├── Prefabs/
├── Materials/
├── Audio/
├── Videos/
├── Resources/
└── UI/
```

## Tecnologie utilizzate

* Unity
* C#
* TextMeshPro
* Unity UI
* Unity Audio System
* Unity Video Player

## Installazione

Clonare la repository:

```bash
git clone https://github.com/Blackinfinityro/Progetto-unity-taxi-driver-gg.git
```

Aprire il progetto tramite Unity Hub utilizzando una versione compatibile di Unity.

## Obiettivo del gioco

* Evitare le collisioni con il traffico.
* Sopravvivere il più a lungo possibile.
* Ottenere il punteggio più alto.
* Migliorare il proprio record personale.

## Autore

Rosario Tabone

Progetto realizzato come esperienza di sviluppo videoludico con Unity, focalizzato sulla programmazione gameplay, sulla generazione procedurale e sulla progettazione dell'interfaccia utente.
