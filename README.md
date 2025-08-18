# Product-api-react-rest

Este é um sistema completo de gerenciamento de produtos, composto por **frontend** em React + TypeScript e **backend** em ASP.NET Core com uma API REST para criação, listagem e gerenciamento de produtos.

---

## Tecnologias utilizadas

**Frontend:**

* React com TypeScript
* Axios para requisições HTTP
* React Router para navegação entre páginas
* CSS/SCSS (ou Tailwind) para estilização
* Vite como bundler e dev server

**Backend:**

* ASP.NET Core 8
* C# com Clean Architecture e DTOs
* SQLite como banco de dados (ou MySQL, se configurado)
* Entity Framework Core
* Swagger para documentação da API

---

## Instalação e execução

### Backend

1. Acesse a pasta do backend:

```bash
cd backend
```

2. Restaure os pacotes NuGet:

```bash
dotnet restore
```

3. Execute o backend:

```bash
dotnet run
```

> Por padrão, o backend estará rodando em `https://localhost:7275`.

### Frontend

1. Acesse a pasta do frontend:

```bash
cd frontend
```

2. Instale as dependências:

```bash
npm install
```

3. Execute o frontend:

```bash
npm run dev
```

> O frontend estará acessível em `http://localhost:5173`.

---

## Funcionalidades

**Frontend:**

* Listar produtos existentes
* Adicionar novos produtos
* Visualizar produtos em tabela formatada
* Navegar entre páginas usando React Router

**Backend:**

* Endpoints REST para CRUD de produtos
* Validação de dados via DTOs
* Persistência com EF Core (SQLite/MySQL)
* Swagger para testar endpoints manualmente

---

## Observações

* Certifique-se de que o CORS está habilitado no backend para aceitar requisições do frontend.
* Use apenas os arquivos necessários do frontend para rodar a interface.
* O backend deve estar rodando e configurado antes de acessar o frontend.

