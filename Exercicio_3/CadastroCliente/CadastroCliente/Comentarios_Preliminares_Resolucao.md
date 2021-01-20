# Comentários gerais sobre a resolução do exercício
O exercício de forma geral cumpriu o objetivo, foi possível criar o banco de dados, a tabela necessária, conectar com o banco ajustando a string de conexão conforme minha base.

O cadastro funcionou normalmente, com algumas ressalvas que ficaram descritas abaixo nos tópicos de correções.

Se atenta para os comentários e também para as correções que mencionei. Cria uma nova branch no teu repo, com um nome sugestivo, aplica as correções nela, e sobe.

# Detalhes que acho importante comentar - Banco de Dados

1. O script de criação do database poderia ter ficado junto com o script de criação das tabelas, como se fosse o script de implantação do sistema mesmo.
2. Outra coisa, no MySQL, quando tu vai rodar um script manualmente, se no script não tiver a instrução "USE nome_da_base;" bem no topo do script, ele vai rodar o script na base que estiver selecionada no workbench. Tem que se atentar com isso, por boa prática, sempre coloca essa instrução, pois eu rodei teu script direto aqui, com outra base selecionada e ele criou a tabela lá.
3. Ainda sobre o banco, conforme falamos, ao meu ver, não é correto usar o CPF/CNPJ como chave e sim somente como UNIQUE, sugiro deixar apenas o codcliente como PK.
4. Na ConnectionString, é interessante informar a porta também, usando a tag "port", pois nem sempre o banco pode estar na porta padrão em todas as máquinas, e isso pode causar um erro de conexão.

# Detalhes que acho importante comentar - Software
1. O campo do CPF/CNPJ deve ser sempre do mesmo tamanho, mudando apenas a máscara e label.
2. Quando abrimos uma interface a partir de outra (o cadastro a partir da consulta), ideal é abrirmos sempre com ShowDialog(), pra evitar que o usuário possa clicar na tela de trás sem fechar a atual, pois nesse caso eu fiz isso e abri 5x a tela de cadastro.
3. Na formatação do campo de CPF/CNPJ, tu SEMPRE formata pro CPF e depois faz um IF pra formatar pro CNPJ, pra ficar mais "correto", deveria fazer um IF/ELSE, fica melhor de entender e evita de fazer uma formatação desnecessária.
4. Nos MessageBox, procura sempre colocar ao menos os 4 parâmetros principais: Mensagem, Título, Botões e Ícone, pra deixar o software mais amigável.
5. Evita de deixar métodos com regras na interface, como o de validar email por exemplo. Se possível, agrupa todas essas validações com regras em uma só classe, e usa a partir de lá, pois ai tu pode até reutilizar dentro do mesmo software. Pensa no conceito do reuso sempre quando fizer algo, ao criar OK, deixa na tela, depois de pronto, refatora e da uma melhorada.
6. Não entendi o uso do "this.carregando". Ele é declarado como true porém no construtor ele sempre é passado para false, qual o objetivo?
7. Nos likes da Consulta de Clientes, ou qualquer outra concatenção de string com símbolos, tenta sempre usar o string.Format() do C#, ao invés de concatenar com "+", pois isso pode causar problemas dependendo da string que tu tentar concatenar, e usar o método atende melhor as boas práticas.
   
# Correções a serem efetuadas - Software (vistos em uso)
1. Está permitindo cadastrar cliente com Telefone e Celular em branco. Deve obrigar pelo menos um deles, conforme a especificação.
2. O campo Data de Nascimento não deve vir preenchido com a data atual, deve ficar em branco, pois o cliente deverá preencher de acordo.
3. Quando fechar a tela de Cadastro de Usuário, pode dar um refresh na grid, pra já apresentar um novo cadastro caso ele tenha sido feito ou atualizar as informações apresentadas.
4. Criei um cliente com um CPF válido e logo depois, criei outro cliente com outro CPF, até aí ok. Abri o cliente 2, troquei o CPF dele para o CPF do cliente 1 e o sistema além de não atualizar nada no banco, ainda fez load do cadastro do cliente 1 na tela.
5. Não redimensionar o campo Tipo de Pessoa conforme a combo, pois o comportamento fica "estranho".
6. Deixar a combo de Tipo de Pessoa ao lado esquerdo do campo de CPF/CNPJ, pois ela solta lá no canto superior direito, parece estar meio "perdida" na tela (lembra sobre a questão de coesão que comentei no enunciado.)

# Correções a serem efetuadas - Software (code review e fonte)
1. A classe de Enums não tem uso em lugar nenhum. Se ela não será usada, pode ser removida.
2. Agrupar os métodos de validação (CPF/CNPJ e email) em apenas uma classe. Pode ser uma classe Validations mesmo, mas os métodos devem ficar somente nela, facilitando a manutenção e centralizando as regras.
3. Conforme falamos, a seleção da combo, deve se basear no Index e não no Value, para selecionar sempre a primeira opção (SelectedIndex = 0). Se mesmo assim desejar manter com o número mágico, adicionar um comentário explicando o porque.
4. Criar um método para calcular a idade e chamar ele no método Leave e no Salva, evitando assim chamar o método "Leave" dentro da rotina Salva.
5. Ajustar a interface para ter uma propriedade CodCliente, pra ser setada pela tela de consulta e usar ela para carregar. Como o CPF deixará de ser chave, basta apenas o codcliente para carregar um novo cadastro.
6. O CarregaTela deve ser pela chave da tabela (no caso, a nova chave "codcliente").
7. Ao chamar a tela de novo cliente, engloba a instância da tela dentro de um using, pra que o sistema possa liberar a memória quando tu fechar a tela.
8. A DbCliente possui uma herança da classe "Conection", mas não a utiliza. Pode ter sido erro de refactor, mas se não tiver uso, retirar a herança.
9. Para abrir a conexão quando for necessário, não precisa fazer isso em cada método que usa ela. Pode criar um método que vai ler a ConnectionString do arquivo de config, abrir a conexão e te retornar ela, ai na Db, tu pode dar um using nela. (Se quiser um exemplo, eu tenho pra te passar, ou podemos falar sobre e eu te explico). Até porque, se por acaso tu mudar o nome dela de "ConnectionMySQL" pra qualquer outra coisa, vai precisar corrigir em um monte de lugares.
10. Usar o LAST_INSERT_ID() como vimos, após o insert, pra pegar o código, no lugar daquele select com order by. (Tenta usar o ExecuteScalar pra pegar o resultado também, não um DataReader.)
11. Ao refatorar a abertura da conexão, encapsulando ela, não esquece de verificar se a conexão já não está aberta, antes de tentar abrir uma nova, por segurança. Aproveita esse refactor, e aplica um tratamento de exceção também ao abrir a conexão, porque hoje se a ConnectionString estiver errada, o software simplesmente crasha ao tentar conectar. (Já treina os Try/Catch aqui)