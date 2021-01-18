# Exercício 2 - Lógica com Substring (level 2) usando Arquivo de Configuração

O objetivo deste exercício é testar a lógica usando leitura de arquivos .txt e Substring, baseado em uma configuração que deverá estar disponível no arquivo de configurações da aplicação, podendo assim ser alterada pelo cliente conforme necessário.

## Especificações

Efetuar a leitura de arquivos TXT de uma pasta determinada no arquivo de configuração. Com esta leitura, iremos identificar a qual cliente pertence aquele arquivo e separar o mesmo em pastas, conforme o nome do cliente. Teremos 2 tipos de arquivo: **Cadastro** e **Item**. Com o tipo de arquivo e cliente identificados, o arquivo .txt lido deverá ser **MOVIDO** para a pasta de destino. Além disso, será necessário gerar um log de processamento onde será informado o nome do cliente, nome do arquivo e a quantidade de produtos comprados.

## Regras Gerais

Na primeira linha de cada arquivo, estará informado qual o tipo dele, começando na posição 1 e com tamanho 4. Na segunda linha de cada arquivo do tipo **ITEM**, estarão informadas as quantidades compradas de um determinado produto, começando na posição 45 e com tamanho 3 (máximo 999).

## Regras do Arquivo "Cadastro"

Dentro do arquivo **Cadastro**, na primeira linha do mesmo, o código do cliente encontra-se a partir da posição 10 e pode ter até 12 caracteres. O identificador de tipo de arquivo encontra-se nos 4 primeiros caracteres da primeira linha, com o texto "CADS".

## Regras do Arquivo "Item"

Dentro do arquivo **Item**, na primeira linha do mesmo, o código do cliente encontra-se a partir da posição 20 e pode ter até 12 caracteres. O identificador de tipo de arquivo encontra-se nos 4 primeiros caracteres da primeira linha, com o texto "ITEM". Na segunda linha do mesmo, iniciando na posição 45 e com tamanho de máximo 3 caracteres encontra-se a quantidade comprada do produto por aquele cliente.

## Objetivos

1. Identificar o tipo do arquivo: Cadastro ou Item
2. Identificar então o código do cliente, conforme o tipo de arquivo
3. Identificar, quando arquivo do tipo **Item**, a quantidade comprada pelo cliente naquele arquivo
4. Com base nisso, criar uma subpasta para o cliente e mover o arquivo .txt lido para dentro dela
5. Além disso, deve-se logar em um arquivo separado o nome do arquivo, nome do cliente e a quantidade comprada

## Validações

1. O sistema deve validar se o diretório do cliente já existe. Caso não exista, deve criar o mesmo.
2. Caso exista um arquivo com o mesmo nome dentro do diretório do cliente já criado, o arquivo deve ser DELETADO antes do novo arquivo ser movido
3. O nome do arquivo txt não pode ser alterado ao ser movido
4. Se caso o arquivo estiver em branco, o sistema deve ignorar o mesmo e gravar num txt o log com o nome do arquivo que foi lido e o motivo da falha
5. Se não for encontrado a palavra chave "CADS" ou "ITEM" no arquivo, logar o nome do arquivo e o motivo
6. Se no arquivo **ITEM** a quantidade for igual a zero OU for um valor não numérico, logar o nome do arquivo e o motivo "Quantidade inválida ou igual a zero!"
7. Se o código do cliente for diferente dos especificados no arquivo de configuração, logar o nome do arquivo txt e o motivo "Cliente inexistente na configuração!"
8. Se a pasta de origem dos arquivos (conforme configuração) não existir ou não for acessivel, apresentar alerta **de erro** para o usuário e abortar a execução do programa
9. Se a pasta de destino dos arquivos (conforme configuração) não existir, ela deverá ser criada no momento de gravar o primeiro arquivo lá

## Geração dos Logs
1. Os logs de processamento deverão ser gerados na raiz da pasta de destino (que será setada no arquivo de configuração), com o nome "Log_Processamento_{DataEHoraAtual}.log"
   1. A {DataEHoraAtual} deve ter o formato "AnoMesDia_HoraMinutoSegundo", por exemplo: "20201206_134523"
   2. Nos dados do cliente, o log deve ter o formato: "NomeCliente - NomeArquivo - X unidades compradas", onde "X" é o valor lido do arquivo "ITEM"
2. Os arquivos que apresentarem falhas de validação deverão ser movidos para uma subpasta chamada "Erros", dentro da pasta de destino
3. Os logs de erro deverão ser gerados na raiz da pasta de destino (que será setada no arquivo de configuração), com o nome "Log_Processamento_Erros_{DataEHoraAtual}.log"
   1. A {DataEHoraAtual} deve ter o formato "AnoMesDia_HoraMinutoSegundo", por exemplo: "20201206_134523"
   2. Se o arquivo tiver um cliente válido, o log deve ter o formato: "NomeCliente - NomeArquivo - Motivo do Erro"
4. No log, não será necessário informar o path completo para o arquivo, somente o nome dele e o motivo da falha, pois todos os que apresentarem erros estarão contidos na subpasta "Erros"

## Dicas Gerais
1. Para ler os dados do arquivo de Configuração, utilizar o método **ConfigurationManager.AppSettings["Key"]**, onde "Key" é o identificador do valor a ser lido, conforme linha de exemplo já deixada no arquivo de configuração
2. Para mover o arquivo, devem ser informados a origem e destino do mesmo. Dessa forma, é possível usar uma variável para guardar o nome do arquivo e então montar o caminho de destino dele usando Path.Combine com a pasta de destino e o nome do arquivo, facilitando o entendimento.

## Nomes de Clientes - Adicionar no arquivo de configuração e ler a partir dele

Criar as pastas dos clientes com estes nomes, conforme o código:

Cliente código 1231231 - "Ubisoft"

Cliente código 111222333444 - "From_Software"

Cliente código 987654321 - "Steam"

Cliente código 777888 - "CD_Projekt_Red"
