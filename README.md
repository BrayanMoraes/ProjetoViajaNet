# ProjetoViajaNet
Projeto para processo seletivo da empresa Viaja Net

# Passos para rodar o projeto
1 - Altere a string de conexão na classe Startup no ProjectWeb para que o projeto consiga encontrar sua instancia do SQL.
2 - Rode o Comando Update-Database para executar o migration
3 - Insira manualmente alguns items nata tabela *ItemType*, esta tabela é uma tabela estatica, ou seja não possui tela de cadastro para se inserir informações nela.
4 - Execute o projeto.

# Detalhes do projeto
O projeto foi feito com Code First, utilizando EntityFrameworkCore com injenção de dependência e inversão de controle, também foram utilizados os padrões de projeto : Repository, Facade e UnitOfWork.
