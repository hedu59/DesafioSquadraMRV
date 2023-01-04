# Desafio MRV-SQUADRA


=> Conexão com SQL Server

=> CQRS com MediatR

=> Microservices Menssageria com RabbitMQ

=> Registro de Log MongoDb

=> Docker Compose com criação de: SQL Server, MongoDb, RabbitMQ.

############################################################################################

BACK:

1 - Clone o repositório

2 - Install docker desktop/docker cli

3 - Navegue até a pasta docker compose pelo prompt e digite: docker-compose up -d
	Deverá ser criada as imagens do SQL Server, MongoDb, RabbitMQ

4 - Abrir aplicação Prototype: No console de gerenciador de pacotes escolher o projeto:
	Infraestructure\Prototype.Infra.Data e digitar o comando:
	update-database para criação do banco (Prototype) no SQL Server
	
	Dados de conexão do banco:
	{
		Host: localhost
		Database: Prototype
		Username: sa
		Password: Secret@123
	}

	Dados de conexão RabbitMQ:
	{
		Host: http://localhost:15672
		Username: guest
		Password: guest
	}
	
	Fluxo:
	{ 
		Executar API Prototype, Atualizar Invitation existente (Para Status: true). 
		Ao atualizar uma Invitation (Para Status: true) o processo irá produzir uma mensagem RabbitMQ para uma fila chamada: mail_message
	}

5 - Abrir aplicação MessageConsumerApi: Ao Executar a aplicação o consumer começará a consumir as mensagens produzidas
	pela API prototype e irá salvar a mensagem como log de transação no mongo Db.



FRONT:

1 - Clone o repositório

2 - Executar o comando: npm i

3 - Executar o comando: ng s


IMAGENS:

***FLUXO DE TRABALHO***
![Screenshot-7](https://github.com/hedu59/DesafioSquadraMRV/blob/develop/5-FluxoDeTrabalho.png)

***DOCKER COMPOSE***
![Screenshot-1](https://github.com/hedu59/DesafioSquadraMRV/blob/develop/1-DockerCompose.png)

***IMAGENS DOCKER***
![Screenshot-2](https://github.com/hedu59/DesafioSquadraMRV/blob/develop/2-ImagensDocker.png)

***CONSUMER***
![Screenshot-3](https://github.com/hedu59/DesafioSquadraMRV/blob/develop/3-Consumer.png)

***MENSAGEM PRODUZIDA***
![Screenshot-4](https://github.com/hedu59/DesafioSquadraMRV/blob/develop/4-MensagemProduzida.png)

***INVITED***
![Screenshot-5](https://github.com/hedu59/DesafioSquadraMRV/blob/develop/6-Invited.png)

***ACCEPTED***
![Screenshot-6](https://github.com/hedu59/DesafioSquadraMRV/blob/develop/7-Accepted.png)
