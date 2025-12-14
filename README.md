# Gestionnaire de Quêtes 🎮

## 📖 Présentation
Le **Gestionnaire de Quêtes** est un projet en C# qui permet de gérer des quêtes pour des joueurs.  
Il offre une architecture claire et modulable pour créer, attribuer et compléter des quêtes avec des récompenses.  
Un **joueur prédéfini** est déjà disponible au lancement du projet, ce qui permet de tester immédiatement les fonctionnalités.

---

## ✨ Fonctionnalités principales
- Créer des quêtes simples ou composites.  
- Attribuer des quêtes aux joueurs (un joueur prédéfini est déjà inclus).  
- Suivre la progression et les quêtes complétées.  
- Gérer les récompenses associées aux quêtes.  

---

## 🗂️ Structure du projet
Le projet est organisé en plusieurs dossiers :

- **Interfaces/** → Contrats (`IQuest`, `IQuestObserver`, `IRewardStrategy`)  
- **Models/** → Classes de base (`Reward`)  
- **Enums/** → Types énumérés (`QuestType`)  
- **Players/** → Gestion des joueurs (`Player`)  
- **Quests/** → Quêtes (`SimpleQuest`, `CompositeQuest`)  
- **Strategies/** → Stratégies de récompense (`FixedRewardStrategy`, `ScaledRewardStrategy`)  
- **Observers/** → Journal et observateurs (`QuestJournal`, `QuestJournalObserver`)  
- **Managers/** → Gestionnaire central (`QuestManager`)  

---

## 🚀 Lancer le projet

### 1 Prérequis
- **.NET 10 SDK** installé sur votre machine.  
  👉 [Télécharger .NET](https://dotnet.microsoft.com/download)

### 2 Cloner le projet

```bash
git clone https://github.com/ton-compte/GestionnaireDeQuetes.git
```

### 3 lancer le projet

- Placez vous dans le dossier du code

```bash
cd ./GestionnaireDeQuetes/
```

- Restaurer les dépendances 

```bash
dotnet restore
```

- Compiler le projet 

```bash
dotnet build
```

- Exécuter le projet

```bash
dotnet run
```

