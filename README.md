# 💰 SalesWebMvc - ASP.NET Core MVC

---

## Descrição do Projeto
Este projeto é uma aplicação web construída utilizando ASP.NET Core MVC com Entity Framework Core para gerenciamento de vendedores, departamentos e registros de vendas. O sistema permite registrar e gerenciar vendedores, controlar suas vendas e organizar os dados em departamentos. Além disso, a aplicação fornece filtros de busca simples e agrupada para facilitar a navegação e análise das vendas.

O layout da aplicação foi desenvolvido com Bootstrap para garantir uma interface responsiva e amigável.

## Funcionalidades

### 1. Gerenciamento de Vendedores
- Cadastro, visualização, edição e exclusão de vendedores.
- Cada vendedor é associado a um departamento.
  
### 2. Gerenciamento de Departamentos
- CRUD completo para departamentos, permitindo associar múltiplos vendedores.
  
### 3. Registros de Vendas
- Adição e gerenciamento dos registros de vendas, incluindo valor da venda, data e status (pago, pendente, cancelado).
- Cada registro de venda está associado a um vendedor.
  
### 4. Filtros de Busca
- Busca simples: Filtros para buscar registros de vendas simples por data.
- Busca agrupada: Permite a exibição de vendas agrupadas por data.
  
### 5. Design Responsivo com Bootstrap
- O sistema foi estilizado com Bootstrap para oferecer uma experiência de usuário moderna e responsiva, acessível em diferentes dispositivos.
  
## Tecnologias Utilizadas
### Back-End:
- ASP.NET Core MVC: Framework usado para estruturar a aplicação web seguindo o padrão MVC (Model-View-Controller), proporcionando uma organização clara e escalável do código.
- Entity Framework Core: Usado para comunicação com o banco de dados, permitindo o mapeamento objeto-relacional (ORM) e facilitando as operações de CRUD (Create, Read, Update, Delete).
  
### Front-End:
- Bootstrap: Framework CSS usado para criar uma interface limpa, responsiva e acessível. O uso do Bootstrap garante que o sistema funcione bem em dispositivos móveis e desktop.
  
### Banco de Dados:
- MySQL: Utilizado como banco de dados relacional para armazenar vendedores, departamentos e registros de vendas.
  
### Filtros de Busca:
- LINQ: Utilizado para implementar as funcionalidades de filtros e agrupamento de dados de forma eficiente.
  
## Funcionalidades de Filtros
### Busca Simples:
- Busca por data: Filtra vendas por intervalos de datas.

### Busca Agrupada:
- Agrupamento por data: Agrupa as vendas por períodos (dia, mês, ano).
- Agrupamento por departamento: Filtra e agrupa as vendas por departamento.
  
## Estrutura de Pastas
- /Controllers: Contém os controladores do MVC responsáveis pelo fluxo de dados e lógica de negócios.
- /Models: Contém as classes do modelo de dados, incluindo Seller, Department, e SalesRecord.
- /Views: Contém as páginas de visualização em Razor que representam a interface do usuário.
- /wwwroot: Contém os arquivos estáticos como CSS, JavaScript e imagens. O Bootstrap está integrado nesta pasta.

## Estrutura de Dados

### Modelos Principais

#### Seller (Vendedor):
- Id: Identificador único.
- Name: Nome do vendedor.
- Email: Email do vendedor.
- BirthDate: Data de nascimento.
- BaseSalary: Salário base.
- Relacionamento: Cada vendedor pertence a um Department.
  
#### Department (Departamento):
- Id: Identificador único.
- Name: Nome do departamento.
  
#### SalesRecord (Registro de Vendas):
- Id: Identificador único.
- Date: Data da venda.
- Amount: Valor da venda.
- Status: Status da venda (pago, pendente, cancelado).
- Relacionamento: Cada venda pertence a um Seller.
  
## Contribuições
Contribuições são bem-vindas! Se você deseja contribuir, faça um fork do repositório, crie uma nova branch, implemente suas mudanças e envie um pull request.

## Contato
- Wagner Santos
- E-mail: wagnerstss@gmail.com
- LinkedIn: https://www.linkedin.com/in/wagnersts/
