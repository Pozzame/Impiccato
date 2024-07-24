# Impiccato

```mermaid
flowchart TD
    A[Start] --> B[Initialize Random and load JSON file]
    B --> C[Clear console]
    C --> D[Select a random word from JSON]
    D --> E[Initialize found letters as empty string]
    E --> F[Found the word loop]

    F --> G[Display ---Found the word---]
    G --> H[Prompt user to guess the word]
    H --> I[Display guessed letters and underscores]
    I --> J[Read user's guessed word]

    J --> K{Is guessed word correct?}
    K --> |Yes| L[Break loop and display You won!!]
    K --> |No| M[Display Wrong word]
    M --> N[Prompt user to guess a letter]
    N --> O[Read user's guessed letter]
    O --> P[Clear console]

    P --> Q{Is letter in the word?}
    Q --> |Yes| R[Display how many times the letter is present]
    R --> S[Add letter to found letters]
    Q --> |No| T[Display Not present]

    S --> F
    T --> F
    L --> U[End]

classDef default fill:#f0f,stroke:#333,stroke-width:4px;
```