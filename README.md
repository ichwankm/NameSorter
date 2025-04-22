![.NET Build & Test](https://github.com/ichwankm/NameSorter/actions/workflows/dotnet.yml/badge.svg)

# NameSorter

## 📋 Description

**NameSorter** is a .NET Console Application built with clean architecture and SOLID principles.It reads a list of names from a text file and sorts them alphabetically by last name, then saves and displays the sorted list.

This solution includes:
- A clean, testable console app
- A file-based sorting engine
- Unit tests with xUnit

---

## ✅ Prerequisites

- .NET 8 SDK
- Visual Studio 2022 / Visual Studio Code

---

## 🚀 Getting Started

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/NameSorter.git
   cd NameSorter
2. **Update the input file**:
   Modify the names inside `Files/unsorted-names-list.txt`
3. **Run the app**:
   ```bash
   dotnet run --project Name_Sorter_Refactor.App
4. **Output**:
   - Console will display the sorted list
   - Output file: Files/sorted-names-list.txt will be created/updated
  
---

## ⚙️ Usage Example

```bash
Input (unsorted-names-list.txt):
Orson Milka Iddins
Erna Dorey Battelle
Flori Chaunce Franzel
Odetta Sue Kaspar
Roy Ketti Kopfen
Madel Bordie Mapplebeck
Selle Bellison
Leonerd Adda Mitchell Monaghan
Debra Micheli
Hailey Avie Annakin

Output (sorted-names-list.txt):
Hailey Avie Annakin
Erna Dorey Battelle
Selle Bellison
Flori Chaunce Franzel
Orson Milka Iddins
Odetta Sue Kaspar
Roy Ketti Kopfen
Madel Bordie Mapplebeck
Debra Micheli
Leonerd Adda Mitchell Monaghan
```

---

## 💪 Running Tests

To run the unit tests:
```bash
dotnet test
```
Tests are written using xUnit and can be found in the Name_Sorter_UnitTest project.

---

## 📁 Project Structure

```bash
Name_Sorter/
├── Name_Sorter_Refactor/        # Console entry point
│   └── Files/                   # Input/output data files
└── Name_Sorter_UnitTest/        # Unit tests using xUnit
```

---

## 🙌 Contributions

Feel free to fork and improve! Pull requests are welcome 🚀
