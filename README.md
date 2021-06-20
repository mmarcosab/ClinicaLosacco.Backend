# Sistema para clinica


## Tecnologias

Backend:

- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/) - Linguagem de programa��o utilizada para desenvolvimento do m�dulo backend
- [Spring Boot](https://dotnet.microsoft.com/) - Framewwork utilizado para auxiliar no desenvolvimento do m�dulo backend
- [Swagger](https://swagger.io/) - Para documentar e testar a api
- [xUnit](https://xunit.net/) - Para testes unit�rios e de integra��o
- [Docker](https://www.docker.com/) - Tecnologia utilizada para a entrega da aplica��o
- [MySql](https://www.mysql.com/) - Banco de dados utilizado para armazenar todas as informa��es do sistema
- [Entity Framework Core](https://docs.microsoft.com/pt-br/ef/core/) - Framework utilizado para facilitar o acesso a dados da aplica��o

## Instala��o

#### Docker
- Use o arquivo dockerfile na raiz do projeto e gere uma imagem, exemplo de comandos:
        
        docker build . -- tag repositorio/nome-da-imagem
        docker push tag repositorio/nome-da-imagem
        docker pull repositorio/nome-da-imagem


## Testes


### Testes unit�rios

Para verificar a cobertura de testes:

Instalar o plugin:
- dotnet tool install --global dotnet-reportgenerator-globaltool --version 4.8.6

Executar o comando no projeto de testes:
- dotnet test --verbosity minimal --collect:"XPlat Code Coverage"

Executar o comando no diretorio TestResults:
- reportgenerator "-reports:coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html



## Documenta��o
- Os m�todos est�o disponiveis na rota https://localhost:5001/swagger/index.html



## Docker
### /dockerfile
- Na raiz do projeto existe um arquivo dockerfile, pronto para ser usado e gerar uma imagem docker



## Andamento do projeto:

 - [x] Entidades de dom�nio e testes unit�tios
 - [x] Swagger
 - [ ] Services/UseCases e testes unit�rios
 - [ ] Adapters de entrada testes unit�rios
 - [ ] Modelos de entrada/sa�da e testes unit�rios
 - [ ] Adapters de banco de dados
 - [x] DB Entities e testes unit�rios


 ## Relat�rio de cobertura de c�digo:
 <img src="/code-coverage.png" alt="Code Coverage"/>