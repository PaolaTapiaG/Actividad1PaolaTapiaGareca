CREATE DATABASE COMPUTADORAS;

CREATE TABLE Computadoras (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    Descripcion TEXT,
    Precio DECIMAL(10, 2),
    FechaFabricacion DATE
);

INSERT INTO Computadoras (Nombre, Descripcion, Precio, FechaFabricacion) 
VALUES 
('Laptop XYZ', 'Laptop de alto rendimiento con procesador Intel Core i7 y tarjeta gr�fica NVIDIA GeForce RTX 3080.', 1899.99, '2023-05-10'),
('PC Gamer Extreme', 'PC de escritorio dise�ada para gaming extremo con procesador AMD Ryzen 9 y tarjeta gr�fica AMD Radeon RX 6800 XT.', 2499.99, '2023-03-22'),
('Chromebook ABC', 'Ligera y compacta, ideal para navegaci�n web y trabajo en la nube.', 399.99, '2023-08-05'),
('MacBook Pro', 'Port�til elegante y potente con procesador M1 de Apple y pantalla Retina.', 1799.99, '2023-04-15'),
('Desktop Workstation', 'Estaci�n de trabajo robusta con procesador Intel Xeon y gr�ficos NVIDIA Quadro RTX.', 3499.99, '2023-06-30');

SELECT* FROM COMPUTADORAS