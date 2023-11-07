# Gerenciamento de Estoque de Produtos

Um projeto de exemplo de gerenciamento de estoque de produtos em C# seguindo os princípios SOLID.

## Descrição

Este é um projeto de exemplo que demonstra a aplicação dos princípios SOLID na linguagem de programação C#. O projeto é um sistema de gerenciamento de estoque de produtos, onde os produtos podem ser adicionados, removidos e listados.

## Princípios SOLID Aplicados

- **Single Responsibility Principle (SRP):** Cada classe tem uma única responsabilidade.
- **Open/Closed Principle (OCP):** O código está aberto para extensão (por exemplo, adicionando novos tipos de produtos), mas fechado para modificação.
- **Liskov Substitution Principle (LSP):** As classes de produtos específicos podem ser usadas no lugar da classe base `Product`.
- **Interface Segregation Principle (ISP):** Interfaces são projetadas para serem específicas e coesas.
- **Dependency Inversion Principle (DIP):** As dependências de alto nível (classe `Inventory`) dependem de abstrações (interface `IProductRepository`).


