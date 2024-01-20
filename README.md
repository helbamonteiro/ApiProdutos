# API de Produtos

Bem-vindo à API de Produtos! Esta é uma API básica desenvolvida para fornecer informações sobre produtos. Use-a para criar, listar, atualizar e excluir produtos em seu sistema.

## Documentação da API

### Listar Produtos

**Endpoint:** `/api/produtos`

**Método:** `GET`

**Descrição:** Retorna a lista de todos os produtos disponíveis.

**Exemplo de Resposta:**
```json
[
  {
    "id": 1,
    "nome": "Produto A",
    "preco": 19.99,
    "quantidade": 50
  },
  {
    "id": 2,
    "nome": "Produto B",
    "preco": 29.99,
    "quantidade": 30
  }
]
```

### Obter um Produto Específico

**Endpoint:** `/api/produtos/{id}`

**Método:** `GET`

**Parâmetros:** `id` (ID do produto)

**Descrição:** Retorna informações sobre um produto específico com base no ID fornecido.

**Exemplo de Resposta:**
```json
{
  "id": 1,
  "nome": "Produto A",
  "preco": 19.99,
  "quantidade": 50
}
```

### Adicionar um Novo Produto

**Endpoint:** `/api/produtos`

**Método:** `POST`

**Corpo da Requisição:** 
```json
{
  "nome": "Novo Produto",
  "preco": 24.99,
  "quantidade": 20
}
```

**Descrição:** Adiciona um novo produto à lista.

**Exemplo de Resposta:**
```json
{
  "id": 3,
  "nome": "Novo Produto",
  "preco": 24.99,
  "quantidade": 20
}
```

### Atualizar um Produto Existente

**Endpoint:** `/api/produtos/{id}`

**Método:** `PUT`

**Parâmetros:** `id` (ID do produto)

**Corpo da Requisição:** 
```json
{
  "nome": "Produto Atualizado",
  "preco": 34.99,
  "quantidade": 15
}
```

**Descrição:** Atualiza as informações de um produto existente com base no ID fornecido.

**Exemplo de Resposta:**
```json
{
  "id": 3,
  "nome": "Produto Atualizado",
  "preco": 34.99,
  "quantidade": 15
}
```

### Excluir um Produto

**Endpoint:** `/api/produtos/{id}`

**Método:** `DELETE`

**Parâmetros:** `id` (ID do produto)

**Descrição:** Remove um produto da lista com base no ID fornecido.

**Exemplo de Resposta:**
```json
{
  "mensagem": "Produto removido com sucesso."
}
```

## Configuração e Uso

1. Faça o clone deste repositório.

```bash
git clone https://github.com/seu-usuario/api-produtos.git
```

2. Instale as dependências.

```bash
cd api-produtos
npm install
```

3. Inicie o servidor.

```bash
npm start
```

4. A API estará disponível em `http://localhost:3000/api/produtos`.

## Contribuições

Contribuições são bem-vindas! Se encontrar problemas ou tiver sugestões, sinta-se à vontade para criar problemas ou enviar solicitações de pull.

Obrigado por usar a API de Produtos Simples!
