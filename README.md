# 📦 Product Inventory Management

A sample product inventory management project in C# following SOLID principles.

## 📝 Description

This is a sample project that demonstrates the application of SOLID principles in the C# programming language. The project is a product inventory management system, where products can be added, removed and listed.

## 🌟 Applied SOLID Principles

- **Single Responsibility Principle (SRP):** Each class has a single responsibility.
- **Open/Closed Principle (OCP):** The code is open for extension (e.g. adding new product types) but closed for modification.
- **Liskov Substitution Principle (LSP):** Specific product classes can be used in place of the `Product` base class.
- **Interface Segregation Principle (ISP):** Interfaces are designed to be specific and cohesive.
- **Dependency Inversion Principle (DIP):** High-level dependencies (`Inventory` class) depend on abstractions (`IProductRepository` interface).
