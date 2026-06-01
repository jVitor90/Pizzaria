# Sistema de Gestão para Pizzaria

> Aplicação desktop desenvolvida em C# (.NET Framework) para gerenciamento completo de uma pizzaria — comandas, caixa, estoque, produtos, usuários e financeiro.

---

## Funcionalidades

- **Login com autenticação** — acesso via CPF e senha com criptografia (EasyEncryption)
- **Gestão de Comandas** — abertura, acompanhamento e encerramento de mesas com lançamentos de pizzas e bebidas
- **Gestão de Caixa** — fechamento de comandas com múltiplos métodos de pagamento
- **Gestão de Estoque** — controle de itens por categoria, quantidade e unidade
- **Gestão de Produtos** — cadastro de pizzas, bebidas, adicionais e bordas por categoria
- **Cadastro e Gerenciamento de Usuários** — controle de acesso por cargo
- **Relatório Financeiro** — faturamento por período com filtro de datas
- **Tela de Opções** — menu principal com navegação entre módulos

---

## Tecnologias Utilizadas

| Tecnologia | Versão |
|---|---|
| C# / Windows Forms | .NET Framework 4.7.2 |
| MySQL | via MySqlConnector 2.4.0 |
| EasyEncryption | 1.0.2 |
| Visual Studio | 2019 / 2022 |

---

## Estrutura do Projeto

```
Pizzaria/
├── Pizzaria/
│   ├── Model/                    # Camada de dados (acesso ao banco)
│   │   ├── Banco.cs              # Conexão com MySQL
│   │   ├── Usuario.cs            # CRUD de usuários
│   │   ├── Produtos.cs           # CRUD de produtos
│   │   ├── Mesas.cs              # Gestão de mesas
│   │   ├── Mesas_lancamentos.cs  # Lançamentos por mesa
│   │   ├── Estoque.cs            # Controle de estoque
│   │   ├── Financeiro.cs         # Relatórios financeiros
│   │   ├── Categoria.cs          # Categorias de produtos
│   │   ├── Metodos_pagamento.cs  # Métodos de pagamento
│   │   ├── Lancamento.cs         # Modelo de lançamento
│   │   └── SessaoUsuario.cs      # Sessão do usuário logado
│   ├── FrmLogin.cs               # Tela de login
│   ├── FrmOpcoes.cs              # Menu principal
│   ├── FrmGestaoComandas.cs      # Gestão de comandas
│   ├── FrmGestaoCaixa.cs         # Fechamento de caixa
│   ├── FrmGestaoEstoque.cs       # Controle de estoque
│   ├── FrmGestãoProdutos.cs      # Cadastro de produtos
│   ├── FrmFinanceiro.cs          # Relatório financeiro
│   ├── FrmCadastroUsuario.cs     # Cadastro de usuário
│   ├── FrmGerenciarUsuarios.cs   # Listagem e gestão de usuários
│   ├── FrmPedidos.cs             # Tela de pedidos
│   └── Program.cs                # Ponto de entrada da aplicação
└── Pizzaria.sln
```

---

## Pré-requisitos

- [Visual Studio 2019+](https://visualstudio.microsoft.com/) com suporte a .NET Framework 4.7.2
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) rodando localmente na porta `3306`
- Banco de dados chamado `pizzaria` criado previamente

---

## Como Executar

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/jVitor90/Pizzaria.git
   cd pizzaria
   ```

2. **Configure o banco de dados:**
   - Crie um banco MySQL chamado `pizzaria`
   - Importe o script SQL (se disponível) ou crie as tabelas manualmente
   - As credenciais padrão estão em `Model/Banco.cs`:
     ```
     SERVER:   localhost
     PORT:     3306
     DATABASE: pizzaria
     UID:      root
     PWD:      (vazio)
     ```
   > Altere as credenciais conforme seu ambiente antes de executar.

3. **Abra a solução no Visual Studio:**
   ```
   Pizzaria.sln
   ```

4. **Restaure os pacotes NuGet** via menu `Tools > NuGet Package Manager > Restore Packages`

5. **Compile e execute** com `F5` ou clicando em **Iniciar**.

---

## Banco de Dados

O sistema utiliza **MySQL** com as seguintes entidades principais:

- `usuarios` — dados de login e cargo
- `mesas` — controle de abertura e encerramento de comandas
- `mesas_lancamentos` — itens lançados em cada comanda
- `produtos` — cardápio (pizzas, bebidas, adicionais, bordas)
- `categorias` — agrupamento de produtos
- `estoque` — itens de estoque com quantidade e unidade
- `metodos_pagamento` — formas de pagamento disponíveis
- `financeiro` / `lancamentos` — registros financeiros por período

---

## Pacotes NuGet

| Pacote | Versão | Finalidade |
|---|---|---|
| MySqlConnector | 2.4.0 | Conexão com MySQL |
| EasyEncryption | 1.0.2 | Criptografia de senhas |
| Microsoft.Bcl.AsyncInterfaces | 8.0.0 | Suporte async/await |
| System.Memory | 4.5.5 | Otimização de memória |

---

## Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
