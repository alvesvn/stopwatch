<h1 align="center"> <img src="https://github.com/user-attachments/assets/1597dae5-9ebf-49ea-a6dd-ec1c63bbcc59" alt="logo-repositorio" height="80" widht="80" /></h1> 
<p align="center"> Projeto Stopwatch <b>@balta.io - Fundamentos do C#.</b></p>
<p align="justify">Este é um projeto simples de cronômetro desenvolvido em C#, que permite contar o tempo em segundos ou minutos. Ele oferece uma interface de console interativa para o usuário configurar e iniciar o cronômetro. </p>

### Funcionalidades

- Contagem de tempo em segundos (10s = 10 segundos) ou minutos (1m = 1 minuto).
- Exibição do tempo decorrido no console.
- Opções para iniciar, pausar e resetar o cronômetro.
- Possibilidade de sair do aplicativo ao inserir 0.

### Como funciona

1. Ao iniciar o programa, o usuário será solicitado a inserir o tempo desejado para a contagem, seguido de s para segundos ou m para minutos (por exemplo, 10s ou 1m).
2. O programa faz uma contagem regressiva antes de iniciar o cronômetro.
3. O tempo é exibido no console em intervalos de segundos.
4. Após o término da contagem, o usuário é informado e pode configurar um novo tempo ou sair.

### Exemplo de Uso
```bash
S = Segundo => 10s = 10 segundos
M = Minuto => 1m = 1 minuto
0 - Sair
Quanto tempo deseja contar?
```

### Requisitos
- .NET SDK


### Executando o Projeto
  
<b>1. Clone o repositório:</b>
```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
```

<b>2. Navegue até o diretório do projeto:</b>

```bash
cd stopwatch
```

<b>3. Compile e execute o projeto:</b>
```bash
dotnet run
```

### Estrutura do Código
- Menu(): Responsável por exibir as opções ao usuário e capturar o tempo de contagem.
- PreStart(int time): Realiza uma contagem regressiva antes de iniciar o cronômetro.
- Start(int time): Inicia a contagem do tempo e exibe o tempo decorrido no console.

### Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

### Licença
Este projeto é licenciado sob a Licença MIT. Veja o arquivo LICENSE para mais detalhes.
