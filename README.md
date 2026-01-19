# 🧱 EtBen.DataAccess.EF.Sql

A lightweight, extensible **.NET 10** library implementing the **Repository** and **Unit of Work** patterns using **Entity Framework Core**.

[![NuGet](https://img.shields.io/nuget/v/EtBen.DataAccess.EF.Sql.svg)](https://www.nuget.org/packages/EtBen.DataAccess.EF.Sql)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

---

## 🚀 Overview

`EtBen.DataAccess.EF.Sql` provides a structured and maintainable approach to **data access** in .NET applications.

It implements the **Generic Repository** and **Unit of Work** patterns, simplifying how your application interacts with Entity Framework Core while keeping your data layer **testable**, **extensible**, and **cleanly separated** from business logic.

---

## ✨ Features

- 🧩 **Generic Repository Interfaces** — consistent data access across entities  
- ⚙️ **Repository Factory** — simple integration with dependency injection  
- 🔄 **Unit of Work Pattern** — ensures transactional consistency  
- 🧠 **Clean Architecture Ready** — promotes separation of concerns  
- 🧪 **Easily Testable** — mock repositories for unit testing  
- 💾 Supports **CRUD operations** for any entity type  

---

## 🗺️ EF Schematic

The EF Schematic is a companion project that visually represents the Entity Framework data model used by this library.
It illustrates how entities, keys, and relationships are structured, helping developers quickly understand and extend the data architecture.

[EFSchematic Repository](https://github.com/Vidvar-EtBen/EfSchematic)

---

## 📦 Installation

Install via **NuGet**:

```bash
dotnet add package EtBen.DataAccess.EF.Sql --version 2.0.0
