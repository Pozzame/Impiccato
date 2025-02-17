# Impiccato
Il gioco consiste nell'indovinare la parola.

La parola viene scelta casualmente da una libreria di parole archiviata in un file Json.

Finché la parola non viene individuata, viene chieto di inserire un carattere da riveleare, se presente, nella parola.

- Eseguendo il programma con l'algomento "-d" si attiva la modalità Debug che visualizza la parola segreta ad inizio gioco.

```mermaid
flowchart TD
    A[Inizio] --> B[Leggi contenuto di Lib.json]
    B --> C[Seleziona parola casuale]
    C --> D[Inizializza lettereTrovate e tentativi]
    D --> E{Ciclo indovina la parola}
    E -->|Inizia ciclo| F[Mostra messaggio 'Indovina la parola']
    F --> G[Mostra parola con lettere trovate]
    G --> H[Leggi input parola dall'utente]
    H --> I[Incrementa tentativi]
    I --> J{Parola corretta?}
    J -->|Sì| K[Mostra 'Hai vinto e il numero di tentativi tentativi']
    J -->|No| L[Mostra 'Parola errata']
    L --> M[Mostra 'Prova una lettera']
    M --> N[Leggi input lettera dall'utente]
    N --> O{Lettera presente nella parola?}
    O -->|Sì| P[Mostra quante volte la lettera è presente]
    P --> Q[Aggiungi lettera a lettereTrovate]
    Q --> E
    O -->|No| R[Mostra 'Non presente']
    R --> E
    K --> S[Fine]
```