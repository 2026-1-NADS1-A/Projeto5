-- SISTEMA - Gestão de Assinaturas de Jogos

-- Tabela: PACOTE
CREATE TABLE pacote (
    id_pacote       INTEGER PRIMARY KEY AUTOINCREMENT,
    nome            TEXT    NOT NULL,
    limite_mensal   INTEGER NOT NULL,
    preco_mensal    REAL    NOT NULL
);

-- Tabela: JOGO
CREATE TABLE jogo (
    id_jogo         INTEGER PRIMARY KEY AUTOINCREMENT,
    nome            TEXT    NOT NULL,
    descricao       TEXT,
    disciplina      TEXT,
    faixa_etaria    TEXT,
    ativo           INTEGER NOT NULL DEFAULT 1 
);

-- Tabela: PACOTE_JOGO 
CREATE TABLE pacote_jogo (
    id_pacote   INTEGER NOT NULL,
    id_jogo     INTEGER NOT NULL,
    PRIMARY KEY (id_pacote, id_jogo),
    FOREIGN KEY (id_pacote) REFERENCES pacote(id_pacote),
    FOREIGN KEY (id_jogo)   REFERENCES jogo(id_jogo)
);

-- Tabela: ESCOLA
CREATE TABLE escola (
    id_escola   INTEGER PRIMARY KEY AUTOINCREMENT,
    nome        TEXT    NOT NULL,
    cnpj        TEXT    UNIQUE,
    email       TEXT,
    telefone    TEXT,
    endereco    TEXT,
    id_pacote   INTEGER,  
    FOREIGN KEY (id_pacote) REFERENCES pacote(id_pacote)
);
