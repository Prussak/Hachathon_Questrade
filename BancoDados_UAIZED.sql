CREATE TABLE usuarios (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(255) NOT NULL,
  sobrenome VARCHAR(255) NOT NULL,
  cpf VARCHAR(11) NOT NULL UNIQUE,
  endereco VARCHAR(255) NOT NULL,
  trabalho VARCHAR(255) NOT NULL,
  renda_mensal DECIMAL(10, 2) NOT NULL,
  dinheiro_investido DECIMAL(10, 2) DEFAULT 0,
  pontuacao_serasa INT NOT NULL,
  limite_emprestimo DECIMAL(10, 2) NOT NULL,
  adquiriu_emprestimo BOOLEAN NOT NULL DEFAULT 0,
  codigo_emprestimo VARCHAR(255)
);

CREATE TABLE emprestimos (
  id INT AUTO_INCREMENT PRIMARY KEY,
  codigo_emprestimo VARCHAR(255) UNIQUE,
  usuario_id INT,
  valor_emprestimo DECIMAL(10, 2) NOT NULL,
  parcelas INT NOT NULL,
  via_pagamento VARCHAR(255) NOT NULL,
  valor_pagamento DECIMAL(10, 2) NOT NULL,
  data_inicio DATE NOT NULL,
  data_ultimo_pagamento DATE,
  FOREIGN KEY (usuario_id) REFERENCES usuarios(id)
);

CREATE TABLE emprestimos_bancos (
  id INT AUTO_INCREMENT PRIMARY KEY,
  numero_emprestimos_disponiveis INT NOT NULL,
  fornecedor VARCHAR(255) NOT NULL,
  valores_disponiveis DECIMAL(10, 2) NOT NULL,
  juros_ao_ano DECIMAL(5, 2) NOT NULL
);

