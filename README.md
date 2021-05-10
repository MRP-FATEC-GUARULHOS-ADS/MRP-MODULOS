# MRP FATEC Guarulhos, ADS

### Como baixar o projeto

1. Baixe e instale o [Git](https://git-scm.com/downloads) no seu computador.

2. Configure o [Git](https://git-scm.com/book/en/v2/Customizing-Git-Git-Configuration) com o nome de usuário que quiser e o email que você usou pra se cadastrar no gitHub.

3. Abra o Visual Studio, espere o VS abrir ... espere ... escolha a opção clonar um repositório se for sua primeira vez abrindo o projeto.

![VSCode](/img/vs-git1.jpg)

4. Digite o endereço do projeto na caixa de Local do repositório, escolha a pasta onde o repositório será criado e clique em Clonar, espere...

```
https://github.com/MRP-FATEC-GUARULHOS-ADS/MRP-MODULOS.git
```

![VSCode](/img/vs-git2.jpg)

Pronto, você já tem acesso ao projeto que a gente tá usando

### Mantendo o projeto atualizado

Agora precisa se certificar que toda vez que vai alterar alguma coisa o projeto esteja atualizado, pra isso cheque sempre no canto inferior direito do programa, uma setinha pra cima ↑ (Push) indica que tem mudanças que você fez e ainda não compartilhou, enquanto uma setinha pra baixo ↓ (Pull) indica que tem mudanças online que você ainda não baixou, tenha certeza de sempre estar atualizado e no *branch* certo do projeto, que é o `main`*.

![VSCode](/img/vs-git3.jpg)

### Como contribuir

1. Faça as alterações que quiser no projeto e depois abra a aba 'Team Explorer' em `Exibir > Team Explorer`, ou clique no lápis no canto inferior direito do programa, a tela de alterações será aberta, como na imagem abaixo.

2. digite uma mensagem que expresse suas mudanças de forma clara, clique no + e confirme tudo, ou escolha os arquivos que quer adicionar e inclua-os separadamente.

![VSCode](/img/vs-git4.jpg)

3. Clique na seta do canto inferior direito e na aba que se abrir clique em 'Enviar por push'.

![VSCode](/img/vs-git5.jpg)

Pronto, mudança feita, espero que tenha valido a pena.

### Branches

Nesse momento o repositório tem 3 branches:

original, com o código sem alterações, do jeito que a gente entregou pra Jane no 2° semestre.

testes, onde um projeto foi criado do zero, com um .gitignore e tudo, se quiser fazer alguma alteração muito extrambólica e tiver medo de quebrar o projeto de todo mundo, pode fazer primeiro nesse branch e depois passar pro main.

main, o branch principal de trabalho, se não tiver certeza em que branch trabalhar, trabalhe nesse e esqueça dos outros.

### Coisas à fazer

- Conectar o banco de dados que o Alécio criou no MySQL
- Subir esse banco de dados no Azure
- Padronizar o layout dos projetos
- Enterrar o módulo de compras?

![Saco de carvão](/img/logo.png)
