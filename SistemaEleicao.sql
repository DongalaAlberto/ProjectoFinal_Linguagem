Create database SistemaEleicoes;
use SistemaEleicoes;


CREATE TABLE Eleitor(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100),
    Email VARCHAR(100),
    Matricula VARCHAR(30),
    Votou BIT
);

CREATE TABLE Administrador(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100),
    Email VARCHAR(100),
    Cargo VARCHAR(50)
);

CREATE TABLE Eleicao(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Titulo VARCHAR(100),
    DataInicio DATETIME,
    DataFim DATETIME,
    Estado VARCHAR(30)
);

CREATE TABLE Candidatura(
    Id INT PRIMARY KEY IDENTITY(1,1),
    NomeLista VARCHAR(100),
    DocumentoValido BIT,
    EleicaoId INT,

    FOREIGN KEY(EleicaoId)
    REFERENCES Eleicao(Id)
);

CREATE TABLE Voto(
    Id INT PRIMARY KEY IDENTITY(1,1),
    DataHora DATETIME,
    EleitorId INT,
    CandidaturaId INT,

    FOREIGN KEY(EleitorId)
    REFERENCES Eleitor(Id),

    FOREIGN KEY(CandidaturaId)
    REFERENCES Candidatura(Id)
);