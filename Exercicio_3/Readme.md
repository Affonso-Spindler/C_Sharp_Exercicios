# Exercício 3 - Cadastro de Cliente

O objetivo deste exercício é criar um simples cadastro e consulta de clientes em Windows Forms e salvar os dados em um banco de dados MySQL.

## Especificações

Criar um banco de dados com suas respectivas tabelas necessárias (script de deploy da aplicação), permitindo que a mesma seja executada de forma satisfatória em qualquer computador com o banco de dados instalado.

O cadastro de cliente será composto por 11 campos, sendo eles: Código (gerado automaticamente), Nome, Tipo de Pessoa (Física ou Jurídica), CPF/CNPJ, Email, DDD e Telefone (fixo), DDD e Celular, Data de Nascimento e Idade. As regras para validações dos campos necessários encontram-se mais abaixo no documento.

O projeto deverá se conectar ao banco de dados para permitir o cadastro e consulta de clientes no sistema, persistindo assim os registros.

## Regras Gerais

A tela inicial do sistema deverá ser a tela de Consulta de Clientes, onde haverá um campo de pesquisa, botão para efetuar a consulta e um botão para adicionar um novo cadastro, que abrirá então o formulário de Cadastro de Clientes para inserção. Pode-se pesquisar pelo nome **OU** e-mail do cliente, tratar na consulta para que traga resultados se qualquer um dos campos bater com o que foi digitado. Se não for digitado nada, o sistema deverá mostrar todos os clientes cadastrados.

No formulário de Cadastro de Clientes, deve existir uma toolbar com os botões para Salvar, Excluir e Sair (o uso de ícones para os mesmos é opcional, mas caso sejam usados, utilizar os Resources do projeto para adicionar as imagens, não adicionar em uma pasta solta). Os campos devem estar dispostos de forma coesa, mantendo padrões de tamanho, tipos, máscaras (quando necessário), etc. O campo com o código do cliente cadastrado deverá ser somente leitura.

A tipagem dos dados no banco de dados deve estar de acordo com os dados inseridos em tela. Os campos que tem máscara **NÃO DEVEM** salvar a máscara no banco de dados, somente os valores. A máscara é somente para exibição na interface.

A string de conexão do banco de dados deve ficar no arquivo de configuração da aplicação, permitindo assim a simples alteração em um case de troca de banco de dados, usuários, senhas, etc...

## Regras de boas práticas para os campos

1. Os campos de Nome e Email devem conter no máximo 60 caracteres
2. Os campos de CPF/CNPJ e CEP não devem ser numéricos no banco, evitando que seja necessário tratar os valores que comecem com "0" (zero) por exemplo
3. As máscaras dos campos de CPF/CNPJ devem ser alteradas conforme o Tipo de Pessoa (o padrão será PF ao carregar a tela)
4. Os campos obrigatórios devem, preferencialmente, possuir alguma sinalização em relação a sua obrigatoriedade, seja com um asterisco na label, uma cor de fundo diferente, etc. A forma de mostrar isso ao usuário fica a seu critério.

## Objetivos

1. Efetuar a criação da base de dados e tabelas necessárias (script de deploy)
2. Compreender a criação das chaves primárias (PK), auto increments e a manutenção da integridade de dados
3. Trabalhar com a interface gráfica de forma amigável, mantendo coêrencia entre tamanhos e tipos de campos, organização de informações importantes na ordem de preenchimento e validação de campos obrigatórios, bem como a sinalização destes campos para o usuário de forma clara
4. Entender a passagem de parâmetros da tela de consulta para a tela de cadastro, de forma a carregar um cadastro previamente efetuado de forma correta
5. Trabalhar com leitura dos dados de conexão do banco através de um arquivo de configuração

## Validações

1. Ao cadastrar um cliente, a Data de Nascimento do mesmo não pode ser menor que 1900
2. O CPF/CNPJ do cliente deve ser um número de CPF/CNPJ válido
3. O email do cliente deve ter um formato válido
4. Quando o cadastro for uma inserção, o botão de Excluir não poderá ser clicado
5. A exclusão de um cliente deve pedir uma confirmação ao usuário
6. Os campos Nome, Tipo de Pessoa, CPF/CNPJ e Data de Nascimento são de preenchimento obrigatório
7. Ao preencher a Data de Nascimento, o campo "Idade" deve ser preenchido automaticamente
8. Entre o Telefone fixo e Celular, **pelo menos um deles** deve ser preenchido
9. Os scripts de banco devem sempre validar se a tabela e o banco de dados existe antes de criá-los, evitando erros na execução
10. Não deve ser permitido o cadastro de um cliente com o mesmo CPF/CNPJ já existente na base de dados

## Dicas Gerais

1. Para validar o CPF/CNPJ, pode-se utilizar uma rotina já pronta da internet (existem várias, escolha uma que se adapte e seja de fácil entendimento e uso)
2. Para pegar um número de CPF/CNPJ válido para testes, sugiro utilizar o gerador do 4devs <https://www.4devs.com.br/gerador_de_cpf>
3. As ConnectionStrings possuem uma tag específica no App.config para utilização, elas não ficam dentro da tag AppSettings como as demais configurações. Pesquisar sobre para entender melhor
4. Para ler a string de conexão do App.Config utilize a sintaxe: **ConfigurationManager.ConnectionStrings["NomeDaSuaConexao"].ConnectionString**
5. Existem métodos prontos de validação de e-mail também, que utilizam Expressões Regulares (RegEx) normalmente. Pode-se buscar algum pronto na internet e implementar no código, para validar o campo de e-mail
6. Tente trabalhar o conceito das classes de forma correta, principalmente na questão da classe que será responsável pelas conexões e rotinas do banco de dados
7. Se for efetuar a separação dos arquivos de Interface dos arquivos de regras, criar uma pasta para cada um deles, com nomes sugestivos e de fácil compreensão