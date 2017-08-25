# Projeto: Developer University

Desenvolvimento do projeto para fins de estudo de cadastramento de uma Universidade fictícia chamada: Developer University em Asp.NET MVC 5 & Entity Framework 6. 
Estou procurando seguir os mesmos padrões do tutorial do site: Asp.NET - caso da Universidade Contoso. Porém, com algumas melhorias propostas no código.

## Recursos Utilizados no Desenvolvimento:

- Visual Studio 2015
- Asp.NET MVC 5;
- Entity Framework 6;
- Fluent API;
- Code First;
- SQL Server Management 2014;
- Single Reposity Pattern;
- Bootstrap 3;
- Windows Azure (para deployment do projeto);
- .NET Framework 4.5;

## Execução do Entity Framework nas IDE's: VS 2015/2017:

Ao realizar os comandos:

```
Enable-Migrations

```
e

```
Update-Database -Verbose
```

Se faz necessário criar uma 'connectionString' no arquigo 'WebConfig' com a seguinte descrição (exemplo):

```
<connectionStrings>
    <add name="Aula1Context"
         connectionString="Data Source=(LocalDb)\v12.0;AttachDbFilename=|DataDirectory|\Aula1BD.mdf;
         Initial Catalog=Aula1BD;
         Integrated Security=True"
         providerName="System.Data.SqlClient" />  
  </connectionStrings>

```

Nas versões mais recentes do Visual Studio (2015/2017), se faz necessário criar uma nova instância do localdb do sql no seu computador. A qual poderá ser criado da seguinte maneira:

1) Passo: Abrir o cmd e executar o seguinte comando:

```
> sqllocaldb create "v12.0"

```

2) Passo: Ir até o 'Package Manager Console' e executar o seguinte comando:

```
> Update-Database -Verbose

```

Ao seguir esses passos, evitará de ocorrer o problema/error 50, de conexão com o SQL Server, erro que evita a criação da tabela via 'Code First' do Entity Framework.


(Documentação em Desenvolvimento)



