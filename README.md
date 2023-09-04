# Mercadinho do Magão!
Bem-vindo ao "**Mercadinho do Magão**" - Onde a música se torna mágica! 

### Sobre o projeto
* Uma API que armazena informações dos instrumentos musicais mágicos - *Versão 6.0 do .NET*;
* Implementação de CRUD usando Entity Framework Core como ORM;
* Sistema de autenticação básica e princípios SOLID

Se você está em busca de um violão que toque canções do além, uma bateria que faça todos os espíritos dançarem ou uma flauta que cante canções de fadas, você está no lugar certo! 🧚‍♂️🎸

Prepare-se para uma aventura! Começaremos seguindo um roteiro para o cadastro e as requisições básicas. Depois disso, você terá a liberdade de explorar nossos corredores mágicos à vontade. Vamos lá!

## Instalação

### Clonando Repositório
      
     git@github.com:yuripeixinho/mercadinhoDoMagao.git

### Banco de Dados
* Indicar versão do banco de dados
* Instrução para criar o banco de dados e tabelas necessárias (pode ser um script SQL ou um README específico)



## Rotas da API
Se você deseja explorar e testar os recursos da nossa API, siga este roteiro passo a passo para uma experiência completa:

### Cadastrar Usuário
Temos que criar nosso usuário, pois apenas com ele autenticado somos capazes de fazer as requisições na nossa API.

    POST https://localhost:7011/api/Usuario
   
    Corpo da solicitação JSON: 
    {
      "nome": "Pedro Henrique",
      "email": "ph@gmail.com",
      "senha": "123456"
    }
Agora que temos nosso usuário, temos que efetuar a autenticação e logo seremos capazes de acessar as demais rotas da API.
### Cadastrar Instrumento Mágico
Nosso armazém está vazio! Temos que cadastrar nossos instrumentos mágicos!
    
    https://localhost:7011/api/InstrumentoMagico
    
    Corpo da solicitação JSON:
    {
      "nome": "Violão do além",
      "tipo": "Corda",
      "preco": 799.99,
      "propriedadeMagica": "Canções do além são tocadas e todos os espíritos ao
       redor se manifestam"
    }
para nossa sorte o meu amigo chamado Geovane Pontes Torres (GPT) me emprestou alguns itens que podem ser criados (de forma individual).


{
  "nome": "Flauta Encantada da Serenidade",
  "tipo": "Sopro",
  "preco": 499.99,
  "propriedadeMagica": "Quando tocada suavemente, acalma as tempestades e tranquiliza as mentes inquietas."
}

{
  "nome": "Tambores Trovão da Ressurreição",
  "tipo": "Percussão",
  "preco": 899.99,
  "propriedadeMagica": "Seu ritmo desperta os mortos, trazendo-os de volta à vida para uma dança espetacular."
}

{
  "nome": "Harpia Harmônica",
  "tipo": "Corda",
  "preco": 699.99,
  "propriedadeMagica": "Ao ser tocada, invoca ventos celestiais e encanta pássaros mágicos para uma sinfonia celestial."
}

{
  "nome": "Guitarra das Estrelas Cadentes",
  "tipo": "Corda",
  "preco": 999.99,
  "propriedadeMagica": "Ao tocar uma música, dispara estrelas cadentes no céu, realizando desejos de todos que as veem."
}

{
  "nome": "Tambor da Floresta Encantada",
  "tipo": "Percussão",
  "preco": 749.99,
  "propriedadeMagica": "Cada batida cria uma floresta encantada temporária, cheia de criaturas mágicas e plantas exóticas."
}

{
  "nome": "Violino das Lágrimas de Cristal",
  "tipo": "Corda",
  "preco": 599.99,
  "propriedadeMagica": "Cada nota tocada transforma as lágrimas em cristais preciosos, trazendo alegria e prosperidade."
}

{
  "nome": "Acordeon da Alegria Infinita",
  "tipo": "Sopro",
  "preco": 799.99,
  "propriedadeMagica": "Quando tocado, cria uma aura de felicidade ao redor, fazendo as pessoas dançarem de alegria."
}

{
  "nome": "Pandeiro dos Elementos",
  "tipo": "Percussão",
  "preco": 649.99,
  "propriedadeMagica": "Cada batida invoca um elemento da natureza - fogo, água, terra ou ar - para um espetáculo mágico."
}

{
  "nome": "Saxofone das Emoções Verdadeiras",
  "tipo": "Sopro",
  "preco": 899.99,
  "propriedadeMagica": "Tocar este saxofone revela as emoções verdadeiras das pessoas ao seu redor, criando conexões profundas."
}

{
  "nome": "Piano Fantasma",
  "tipo": "Teclado",
  "preco": 1299.99,
  "propriedadeMagica": "As teclas do piano são tocadas por mãos invisíveis, criando uma melodia assombrosa e cativante."
}








