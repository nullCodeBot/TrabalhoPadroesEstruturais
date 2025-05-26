# TRABALHO DE PROGRAMAÇÃO ORIENTADA A OBJETO

No trabalho são apresentados três padrões de projetos estruturais 
- Composite
- Decorator
- Facade
Esse trabalho tem o intuito de fixar o conteúdo apresentado e entender o conceito por trás de cada padrão.

## Padrão de Projeto: Composite

### Definição

O padrão **Composite** permite tratar objetos individuais e composições de objetos de maneira uniforme, ideal para estruturas hierárquicas.

### Exemplo: Estrutura de Arquivos e Pastas

Este exemplo representa uma estrutura de diretórios:

- `Arquivo`: Um item simples.
- `Pasta`: Um item composto que pode conter outros arquivos ou pastas.

Ambos derivam de `ItemSistema`, permitindo que sejam manipulados da mesma forma.

### Benefícios demonstrados

- Tratamento uniforme de objetos e coleções.
- Suporte à composição de objetos recursiva.
- Organização lógica de hierarquias complexas.

## Padrão de Projeto: Decorator

### Definição

O padrão **Decorator** permite adicionar funcionalidades a objetos dinamicamente, sem alterar a estrutura das classes existentes. Ele promove composição ao invés de herança.

### Exemplo: Sistema de Notificações

Este exemplo demonstra o envio de notificações por múltiplos canais:

- `NotificacaoEmail`: Implementação base.
- `NotificacaoSMS` e `NotificacaoPush`: Decoradores que adicionam funcionalidades extras.

Esses decoradores podem ser empilhados para criar combinações dinâmicas de envio.

### Benefícios demonstrados

- Flexibilidade para adicionar funcionalidades em tempo de execução.
- Reutilização de código.
- Independência entre as funcionalidades adicionais.

## Padrão de Projeto: Facade (Fachada)

### Definição

O padrão **Facade** fornece uma interface unificada para um conjunto de interfaces em um subsistema. Ele define uma interface de nível mais alto que torna o subsistema mais fácil de usar.

### Exemplo: Sistema de Biblioteca

Este exemplo simula um sistema de empréstimos de livros, com três subsistemas:

- `Catalogo`: Verifica disponibilidade de livros.
- `Usuario`: Verifica pendências do usuário.
- `Emprestimo`: Registra o empréstimo.

A classe `BibliotecaFacade` encapsula a complexidade desses três componentes e fornece um único método `EmprestarLivro()` para o cliente utilizar.

### Benefícios demonstrados

- Simplicidade de uso para o cliente.
- Redução de acoplamento com subsistemas internos.
- Encapsulamento de lógica complexa em uma fachada.