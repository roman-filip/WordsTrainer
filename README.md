# WordsTrainer

## Datový model - Vazby mezi entitami

```mermaid
classDiagram
    class Language {
        -Guid Id
        -string Code
        -string Name
    }

    class Word {
        -Guid Id
        -string Text
        -Language Language
    }

    class WordTranslation {
        -Guid Id
        -Word Word1
        -Word Word2
        -WordTranslationCategory? Category
    }

    class WordTranslationCategory {
        -Guid Id
        -string Name
    }

    Language "1" --> "*" Word
    Word "2" --> "*" WordTranslation
    WordTranslationCategory "0..1" --> "*" WordTranslation
```

### Popis entit

- **Language**: Reprezentuje jazyk (např. English, Czech)
  - `id`: Identifikátor jazyka
  - `code`: Kód jazyka (e.g., "en", "cs")
  - `name`: Název jazyka

- **Word**: Slovo v určitém jazyce
  - `id`: Identifikátor slova
  - `text`: Textová hodnota slova
  - `language`: Odkaz na jazyk

- **WordTranslation**: Vazba mezi dvěma slovy jako překlad
  - `id`: Identifikátor překladu
  - `word1`: První slovo (např. anglické)
  - `word2`: Druhé slovo (např. české)
  - `category`: Volitelná kategorie překladu

- **WordTranslationCategory**: Kategorie/klasifikace překladu
  - `id`: Identifikátor kategorie
  - `name`: Název kategorie