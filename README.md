

# Mercadinho do Magão!
Bem-vindo ao "**Mercadinho do Magão**" - Onde a música se torna mágica! 

Se você está em busca de um violão que toque canções do além, uma bateria que faça todos os espíritos dançarem ou uma flauta que cante canções de fadas, você está no lugar certo! 🧚‍♂️🎸

### Sobre o projeto
* Uma API que armazena informações dos instrumentos musicais mágicos 
*  *Versão 6.0 do .NET*;
* Implementação de CRUD usando Entity Framework Core como ORM;
* Sistema de autenticação básica 
* princípios SOLID

## Instalação

### Clonando Repositório
      
     git@github.com:yuripeixinho/mercadoMagicoDoMagao.git

### Banco de Dados
* Para o banco de dados é utilizado SQLite. O banco já está previamente com população;


### Vamos começar nossa aventura musical interagindo com a API `mercadoMagicoDoMago`.
<details>
  <summary>Se você deseja explorar e testar os recursos da nossa API, siga este roteiro passo a passo para uma experiência completa:</summary>


### Cadastrar Usuário
Temos que criar nosso usuário, pois apenas com ele autenticado somos capazes de fazer as requisições na nossa API.

    {
      "nome": "Usuario",
      "email": "usuario@gmail.com",
      "senha": "123456"
    }
Agora que temos nosso usuário, temos que efetuar a autenticação e logo seremos capazes de acessar as demais rotas da API.

Vamos começar nossa aventura musical interagindo com a API `InstrumentoMagico`.

### 1.1. Listando os Instrumentos Mágicos
Vamos ver quais instrumentos mágicos misteriosos estão disponíveis no mundo da magia!
- **Método**: GET
- **Rota**: `/api/InstrumentoMagico`

### 1.2. Criando um Novo Instrumento Mágico
Vamos criar um instrumento mágico especial. 😄
- **Método**: POST
- **Rota**: `/api/InstrumentoMagico`
  ```json
  {
    "nome": "Flauta da Lua Encantada",
    "tipo": "Sopro",
    "preco": 599.99,
    "propriedadeMagica": "Faz a lua brilhar ainda mais intensamente quando tocada à noite."
  }
### 1.3. Consultando um Instrumento Mágico Específico
Vamos dar uma olhada na Flauta da Lua Encantada que acabamos de criar!
-   **Método**: GET
-   **Rota**: `/api/InstrumentoMagico/:{ID da Flauta da Lua Encantada}`

### 1.4. Atualizando um Instrumento Mágico
Vamos melhorar a propriedade mágica da Flauta da Lua Encantada!
-   **Método**: PUT
- **Rota**: `/api/InstrumentoMagico/:{ID da Flauta da Lua Encantada}`
  ```json
  {
    "nome": "Flauta da Lua Encantada",
    "tipo": "Sopro",
    "preco": 599.99,
    "propriedadeMagica": "Faz a lua brilhar ainda mais intensamente quando tocada à noite."
  }

### 1.6. Calculando o Preço Total por Tipo de Instrumento
Nosso chefe pediu para que a gente veja o preço total que os instrumentos que possuem o **tipo corda** estão custando no total.
-   **Método**: GET
-   **Rota**: `/api/InstrumentoMagico/CalculateTotalPriceByType`

### 1.7. Pesquisando por Propriedade Mágica
Vamos encontrar todos os instrumentos que têm o poder de fazer algo brilhar! ✨
-   **Método**: GET
-   **Rota**: `/api/InstrumentoMagico/SearchByMagicProperty?propriedade=brilhar`

### 1.5. Excluindo um Instrumento Mágico
Adeus, Flauta da Lua Encantada! 😢

-   **Método**: DELETE
-   **Rota**: `/api/InstrumentoMagico/:{ID da Flauta da Lua Encantada}`
</details>

### Endpoints da API `InstrumentoMagico`

| Método | Rota                                  | Descrição                                             |
|--------|---------------------------------------|-------------------------------------------------------|
| GET    | `/api/InstrumentoMagico`             | Retorna todos os instrumentos mágicos disponíveis.   |
| POST   | `/api/InstrumentoMagico`             | Cria um novo instrumento mágico.                     |
| GET    | `/api/InstrumentoMagico/{id}`        | Retorna um instrumento mágico específico pelo ID.    |
| PUT    | `/api/InstrumentoMagico/{id}`        | Atualiza um instrumento mágico específico pelo ID.   |
| DELETE | `/api/InstrumentoMagico/{id}`        | Exclui um instrumento mágico específico pelo ID.     |
| GET    | `/api/InstrumentoMagico/CalculateTotalPriceByType` | Calcula o preço total de instrumentos mágicos por tipo. |
| GET    | `/api/InstrumentoMagico/SearchByMagicProperty`   | Pesquisa instrumentos mágicos por propriedade mágica.  |

### Endpoints da API `Usuario`

| Método | Rota                   | Descrição                                       |
|--------|------------------------|-------------------------------------------------|
| GET    | `/api/Usuario/{id}`   | Retorna um usuário específico pelo ID.         |
| DELETE | `/api/Usuario/{id}`   | Exclui um usuário específico pelo ID.           |
| POST   | `/api/Usuario`        | Cria um novo usuário.                           |









