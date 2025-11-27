CREATE TABLE Socios (
id INT IDENTITY(1,1) PRIMARY KEY,
nombre VARCHAR(50) NOT NULL,
apellido VARCHAR(50) NOT NULL,
dni VARCHAR(15) NOT NULL UNIQUE,
fecha_nacimiento DATE NOT NULL,
numero_socio INT NOT NULL UNIQUE,
cuota_al_dia BIT NOT NULL
);