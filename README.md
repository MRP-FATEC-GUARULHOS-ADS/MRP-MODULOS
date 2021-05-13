# MRP FATEC Guarulhos, ADS

## Como baixar o projeto

1. Baixe e instale o [Git](https://git-scm.com/downloads) no seu computador.

2. Configure o [Git](https://git-scm.com/book/pt-br/v2/Come%C3%A7ando-Configura%C3%A7%C3%A3o-Inicial-do-Git) com o nome de usuário que quiser e o email que você usou pra se cadastrar no gitHub.

3. Abra o Visual Studio, espere o VS abrir ... espere ... escolha a opção clonar um repositório.

![abrindo o VS](/img/vs-git1.jpg)

4. Digite o endereço do projeto na caixa de Local do repositório, escolha a pasta onde o repositório será criado e clique em Clonar, espere ...

```
https://github.com/MRP-FATEC-GUARULHOS-ADS/MRP-MODULOS.git
```

![clonando o repositório](/img/vs-git2.jpg)

Pronto, você já tem acesso ao projeto que a gente tá usando.

## Mantendo o projeto atualizado

Agora toda vez que for abrir o projeto você precisa se certificar que ele esteja atualizado. Pra isso cheque sempre no canto inferior direito do programa, uma setinha pra cima ↑ (Push) indica que tem mudanças que você fez e ainda não compartilhou, enquanto uma setinha pra baixo ↓ (Pull) indica que tem mudanças online que você ainda não baixou, tenha certeza de sempre estar atualizado (setinha pra cima do lado de um número 0) e no *branch* certo do projeto, que é o `main`. [^1]

![Team-explorer](/img/vs-git3.jpg)

## Como contribuir

1. Faça as alterações que quiser no projeto e depois abra a aba 'Team Explorer' em `Exibir > Team Explorer`, ou clique no lápis no canto inferior direito do programa, a tela de alterações será aberta, como na imagem abaixo.

2. Digite uma mensagem que expresse suas mudanças de forma clara

3. Clique no + e confirme tudo, ou escolha os arquivos ou pastas que quer adicionar e inclua-os separadamente (clicando com o direito no item e escolhendo `Preparar`).

![dica](/img/dica.png)

Incluir no commit só os arquivos que você alterou diminui a chance de criar conflitos no Git e te torna uma pessoa melhor, mas tenha certeza de incluir todos os arquivos que você alterou.

![commit](/img/vs-git4.jpg)

4. Clique na seta do canto inferior direito e na aba que se abrir clique em 'Enviar por push'.

![push](/img/vs-git5.jpg)

Pronto, mudança feita, espero que tenha valido a pena.

## Branches

[^1]: Nesse momento o repositório tem 3 branches:

1. **main**, o *branch* principal de trabalho, se não tiver certeza em que *branch* trabalhar, trabalhe nesse e esqueça dos outros.

2. **original**, com o código sem alterações, do jeito que a gente entregou pra Jane no 2° semestre, não suba nada aqui, esse *branch* só existe pra *backup*.

3. **testes**, onde um projeto foi criado do zero, com um .gitignore e tudo, se quiser fazer alguma alteração muito extrambólica e tiver medo de quebrar o projeto de todo mundo, pode fazer primeiro nesse *branch* e depois passar pro main.

## Coisas à fazer

- Documentação dos módulos
    - Diagrama de Caso de Uso
    - Fluxograma
    - Diagrama de Classes
- Documentação do projeto
    - Diagrama de Caso de Uso
    - Fluxograma
    - Diagrama de Classes
- Banco de dados
    - Subir o banco no Azure
    - Conectar o banco de dados MySQL com o Visual Studio
    - Usar esse banco em todos os módulos ...
- Padronizar os módulos
    - nomenclatura das variáveis e elementos do *layout*
    - comentários
    - *layouts*
- Enterrar o módulo de compras?

![Saco de carvão](/img/logo.png)
