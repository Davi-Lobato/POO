# POO — Cadastro de Produtos em C#

Aplicação de console em C# feita para praticar Programação Orientada a Objetos.

## O que o programa faz

Um menu simples para gerenciar uma lista de produtos:

1. **Adicionar produto** — código, descrição, unidade (LT, CX, KG, UN, MT), preço e quantidade
2. **Listar produtos** cadastrados
3. **Remover produto** pelo código
4. **Sair**

## Conceitos praticados

- Classes e objetos (`Produto`)
- Construtor com parâmetros
- Encapsulamento: o preço é privado e só muda pelo `SetPrecoProd`, que rejeita valores inválidos
- Métodos estáticos (`DefUnidade`, `Listar`)
- Coleções com `List<Produto>`

## Como rodar

Precisa do [.NET SDK](https://dotnet.microsoft.com/download) instalado.

```bash
cd program/program
dotnet run
```

Ou abra `program/program.sln` no Visual Studio.
