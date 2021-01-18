# Exercício 1 - Lógica com Substring

O objetivo deste exercício é testar a lógica usando leitura de arquivos .txt e Substring. Os arquivos para teste encontram-se dentro da pasta "Examples".

## Especificações

Será necessário efetuar a leitura de arquivos TXT de uma pasta determinada. Com esta leitura, iremos identificar a qual cliente pertence aquele arquivo e separar o mesmo em pastas, conforme o nome do cliente. Teremos 2 tipos de arquivo: **Cadastro** e **Item**. Com o tipo de arquivo e cliente identificados, o arquivo .txt lido deverá ser **MOVIDO** para a pasta de destino.

## Regras Gerais

Na primeira linha de cada arquivo, estará informado qual o tipo dele, começando na posição 1 e com tamanho 4.

## Regras do Arquivo "Cadastro"

Dentro do arquivo **Cadastro**, na primeira linha do mesmo, o código do cliente encontra-se a partir da posição 10 e pode ter até 12 caracteres. O identificador de tipo de arquivo encontra-se nos 4 primeiros caracteres da primeira linha, com o texto "CADS".

## Regras do Arquivo "Item"

Dentro do arquivo **Item**, na primeira linha do mesmo, o código do cliente encontra-se a partir da posição 20 e pode ter até 12 caracteres. O identificador de tipo de arquivo encontra-se nos 4 primeiros caracteres da primeira linha, com o texto "ITEM".

## Objetivos

1. Identificar o tipo do arquivo: Cadastro ou Item
2. Identificar então o código do cliente, conforme o tipo de arquivo
3. Com base nisso, criar uma subpasta para o cliente e mover o arquivo .txt lido para dentro dela

## Validações

1. O sistema deve validar se o diretório do cliente já existe. Caso não exista, deve criar o mesmo.
2. Caso exista um arquivo com o mesmo nome dentro do diretório do cliente já criado, o arquivo deve ser DELETADO antes do novo arquivo ser movido
3. O nome do arquivo txt não pode ser alterado ao ser movido
4. Se caso a primeira linha do arquivo estiver em branco, o sistema deve ignorar o mesmo e gravar num txt o log com o nome do arquivo que foi lido e o motivo da falha
5. Se não for encontrado a palavra chave "CADS" ou "ITEM" no arquivo, logar o nome do arquivo e o motivo
6. Se o código do cliente for diferente dos especificados abaixo, logar o nome do arquivo e o motivo
7. O nome das pastas NÃO PODE CONTER ESPAÇOS, deve seguir estritamente o nome do cliente conforme enum abaixo

## Nomes de Clientes - Para Criação das Pastas

-- Criar as pastas dos clientes com estes nomes, conforme o código:
Cliente código 1231231 - "Ubisoft"
Cliente código 111222333444 - "From_Software"
Cliente código 987654321 - "Steam"
Cliente código 777888 - "CD_Projekt_Red"
