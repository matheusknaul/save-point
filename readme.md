# SavePoint

**SavePoint** is a lightweight C# library for storing and managing objects in a **persistent key-value storage** without relying on a traditional database. It provides an intuitive API for saving, reading, and updating objects, with optional **transaction-like sessions** for batching and rollback support.

---

## Features

- Persist objects of any class type (`Register<T>`).  
- Supports simple key-value storage in JSON or in-memory providers.  
- Optional session mechanism (`SaveSession`) for batching operations with commit/rollback.  
- Lightweight, dependency-free core.  
- Extensible storage providers.  
- Inspired by the **Memento Pattern** for state snapshots.  

---

## Installation

You can add SavePoint via NuGet (once published):

```bash
dotnet add package SavePoint.Core
dotnet add package SavePoint.Providers.Json
