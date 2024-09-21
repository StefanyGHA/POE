CREATE DATABASE libraryDB
GO

USE libraryDB
GO

-- Crear tabla Libros
CREATE TABLE Books (
    BookID INT PRIMARY KEY IDENTITY(1,1),  -- Identificador ?nico para cada libro
    Title NVARCHAR(255) NOT NULL,          -- T?tulo del libro
    Author NVARCHAR(255) NOT NULL,         -- Autor del libro
    PublishedYear INT                      -- A?o de publicaci?n del libro
)
GO

-- Crear tabla Miembros
CREATE TABLE Members (
    MemberID INT PRIMARY KEY IDENTITY(1,1), -- Identificador ?nico para cada miembro
    FullName NVARCHAR(255) NOT NULL,        -- Nombre completo del miembro
    JoinDate DATE NOT NULL,                 -- Fecha de registro del miembro en la biblioteca
    Email NVARCHAR(255)                     -- Correo electr?nico del miembro
)
GO

-- Crear tabla Prestamo
CREATE TABLE Loans (
    LoanID INT PRIMARY KEY IDENTITY(1,1),   -- Identificador ?nico para cada pr?stamo
    LoanDate DATE NOT NULL,                 -- Fecha en la que se realiz? el pr?stamo
    BookID INT NOT NULL,                    -- Identificador del libro prestado
    MemberID INT NOT NULL,                  -- Identificador del miembro que realiz? el pr?stamo
    FOREIGN KEY (BookID) REFERENCES Books(BookID), -- Llave for?nea a Books
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID) -- Llave for?nea a Members
)
GO