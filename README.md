# SysFrantheskC#
Software para gerenciamento de loja de pequeno porte feito em C# utilizando a ferramenta Visual Studio 2017.

# Sobre o SysFrantheskC#
SysFrantheskC# é um software que desenvolvi para uma empresa local de pequeno porte que vende variedades de mercadorias, para o usuário ter uma maior organização com a parte gerencial e financeira da loja. A aplicação é exclusivamente desktop. Está em desenvolvimento uma aplicação para essa empresa utilizando NodeJS para incluir uma API para ser consumida por uma aplicação desktop e outra mobile.

# Entidades
As entidades se encontram na pasta documentação, onde foi incluido um modelo de entidades.

# Funções
O sistema consiste em algumas funções que atendem a necessidade do usuário, são elas:
  - Gerenciar usuários e permissões de usuários para acesso ao sistema (CRUD)
  - Autenticação de usuários para acesso ao sistema (Autenticação com permissões de administrador e funcionário)
  - Gerenciar mercadorias a serem vendidas na loja (CRUD)
  - Gerenciar vendas feitas (CRUD - PDV)
  - Gerenciar caixa no dia (Abrir caixa com valor inicial - fechar caixa)
  - Fechar comissão de funcionários com base no que venderam ao mês
  - Exibir relatórios relacionados às vendas em um determinado período
  - Exibir informações sobre a empresa
 
# Conceitos aplicados
No desenvolvimento do SysFrantheskC# alguns conceitos foram colocados em prática:
  - Entity Framework model-first (utilizando modelos ADO do visual studio)
  - Conexão ao banco de dados utilizando SQLServer
  - Conceito MVC
    -  Modelagem de entidade (Pasta Models)
    - Views de entidade (Pasta Views)
    - Controladores de entidade (Pasta Controls)
  - CRUD utilizando um ORM (Entity Framework)
