# Sistema para clinica


## Tecnologias

Backend:

- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/) - Linguagem de programação utilizada para desenvolvimento do módulo backend
- [Spring Boot](https://dotnet.microsoft.com/) - Framewwork utilizado para auxiliar no desenvolvimento do módulo backend
- [Swagger](https://swagger.io/) - Para documentar e testar a api
- [xUnit](https://xunit.net/) - Para testes unitários e de integração
- [Docker](https://www.docker.com/) - Tecnologia utilizada para a entrega da aplicação
- [MongoDB](https://www.mongodb.com/) - Banco de dados utilizado para armazenar todas as informações do sistema

## Instalação

#### Docker
- Use o arquivo dockerfile na raiz do projeto e gere uma imagem, exemplo de comandos:
        
        docker build . -- tag repositorio/nome-da-imagem
        docker push tag repositorio/nome-da-imagem
        docker pull repositorio/nome-da-imagem


## Testes


### Testes unitários

Como verificar a cobertura de testes ? 

Instalar o plugin:
- dotnet tool install --global dotnet-reportgenerator-globaltool --version 4.8.6

Executar o comando no projeto de testes:
- dotnet test --verbosity minimal --collect:"XPlat Code Coverage"

Executar o comando no diretorio TestResults:
- reportgenerator "-reports:coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html



## Documentação
- Os métodos estão disponiveis na rota https://localhost:5001/swagger/index.html



## Docker
### /dockerfile
- Na raiz do projeto existe um arquivo dockerfile, pronto para ser usado e gerar uma imagem docker



## Andamento do projeto:

 - [x] Entidades de domínio e testes unitátios
 - [ ] Services/UseCases e testes unitários
 - [ ] Adapters de entrada testes unitários
 - [ ] Modelos de entrada/saída e testes unitários
 - [ ] Adapters de banco de dados
 - [ ] DB Entities e testes unitários
