# Sistema de Estoque - CRUD com C# e ORM 🚀

Este projeto é um **sistema de gestão de estoque** desenvolvido em **C#** utilizando **Entity Framework** (ORM) para facilitar as operações de CRUD (Criar, Ler, Atualizar e Deletar) em um banco de dados MySQL. A aplicação expõe uma **API RESTful** para interação com os dados de estoque, permitindo o gerenciamento de produtos e quantidades.

## 🚀 Funcionalidades

- **CRUD Completo de Produtos**: Permite criar, listar, editar e excluir produtos no estoque.
- **API RESTful**: A API possui endpoints para realizar operações sobre os produtos do estoque.
- **Persistência de Dados**: Utiliza **Entity Framework** para realizar a conexão e manipulação do banco de dados.
- **Migrações**: Suporte a migrações do banco de dados para estruturar e atualizar as tabelas conforme o modelo de dados.

## ⚙️ O que você precisa fazer

### 1. **Criar o Banco de Dados MySQL** 🗃️
Primeiramente, crie um banco de dados no MySQL. Você pode usar o nome `estoque`, ou outro nome que preferir. 

Exemplo de criação de banco:

```sql
CREATE DATABASE estoque;
