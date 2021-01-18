# Comentários gerais sobre a resolução do exercício

Em primeiro lugar, gostei que tu pegou a ideia do arquivo config rapidão e aprendeu a trabalhar com ele, já colocou os códigos de clientes ali e tal e fez funcionar. Muito bom.

Achei legal que aplicou as dicas que te dei do outro exercício, ou seja, já evoluiu nessa parte e aprimorou algumas coisas em relação ao anterior.

**Tua solução resolveu o problema proposto (com alguns detalhes, veja abaixo) e ainda aplicou os feedbacks do exercício anterior em alguns pontos, muito bom!**

# Detalhes que acho importante comentar

1. O programa não indica que terminou de executar (pelo menos aqui não indicou), ele simplesmente fica com a tela do Console aberta, mesmo depois de terminar o processamento, e tem que apertar uma tecla pra fechar, mas não tem nenhuma indicação disso. O ideal é fechar a tela ou mostrar uma mensagem ao terminar.
2. Na linha 32, onde tu valida o path de origem e destino, tu apenas está validando se não foram preenchidas no arquivo de config, porém tu não verifica se, mesmo preenchida, a pasta de origem está acessível ou se ela realmente existe.
3. Na linha 34, tu esqueceu de corrigir o GetFileName lá, manteve a tua lógica do número mágico (a lógica é valida, mas importante lembrar daquele método pra pegar o nome do arquivo).
4. Na linha 51, tua string "pathErros" está dentro do loop foreach, não há necessidade, ela pode ficar fora e só ser usada dentro. É mais uma dica de boas práticas, pois da forma que está feito, tu redeclara e redefine ela N vezes (1x para cada arquivo).
5. A validação da linha 130 é desnecessária. Não precisa verificar se a linha de cabeçalho é menor do que 4, não sei se foi por "fator de cagaço" talvez, mas se foi pra garantir que o arquivo tem pelo menos 4 caracteres na primeira linha, a mensagem do log deveria ser diferente.
6. As variáveis "codCads" e "codItem" nas linhas 145 e 146 não tem nomes sugestivos. Sem saber do que se trata o programa, não fica claro que elas se referem ao código do cliente em cada tipo de arquivo lido.
7. Na validação da linha 165, tu está verificando se o length do arquivo é menor que 2, mas se ele tiver 3 caracteres em qualquer linha, por exemplo, a tua validação não funcionaria. Aqui o correto seria validar se a linha arquivo[1] é diferente de null ou vazia, pois ai tu garante que está validando a linha da quantidade.
8. Gostei do uso do TryParse ali, era o que eu esperava que tu fizesse, tu buscou a solução e usou ela, sem implementar ou gastar tempo em alguma lógica mirabolante por trás. **Parabéns!!!**
9. Gostei também do format para data e hora do log, foi bem utilizado e ficou exatamente como o pedido, só podia ter usado um string.Format ao invés de concatenar com "+" as strings. Mas novamente, **parabéns!!**
10. Os logs de processamento, de erro e a pasta de erros foram salvas dentro da pasta de Origem e não da pasta de destino. Conforme a especificação, está incorreto. Acho que faltou uma atençãozinha aqui!