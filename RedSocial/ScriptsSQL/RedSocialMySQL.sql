-- ============================================
-- CREACIÓN DE BASE DE DATOS Y TABLAS
-- ============================================
CREATE DATABASE RedSocial;
USE RedSocial;

-- Tabla usuario
CREATE TABLE usuario (
  idUsuario INT AUTO_INCREMENT PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL UNIQUE,
  telefono VARCHAR(10) NOT NULL UNIQUE,
  correo VARCHAR(255) NOT NULL UNIQUE,
  contrasenha VARCHAR(255) NOT NULL,
  fechaCreacion DATETIME NOT NULL,
  administrador BOOLEAN DEFAULT FALSE
);

-- Tabla publicaciones
CREATE TABLE publicacion (
  idPublicacion INT AUTO_INCREMENT PRIMARY KEY,
  idAutor INT NOT NULL,
  contenido TEXT NOT NULL,
  fechaCreacion DATETIME NOT NULL,
  FOREIGN KEY (idAutor) REFERENCES usuario(idUsuario)
  ON DELETE CASCADE
);

-- Tabla Comentarios
CREATE TABLE comentario (
  idComentario INT AUTO_INCREMENT PRIMARY KEY,
  idPublicacion INT NOT NULL,
  idAutor INT NOT NULL,
  contenido TEXT NOT NULL,
  fechaCreacion DATETIME NOT NULL,
  FOREIGN KEY (idAutor) REFERENCES usuario(idUsuario) ON DELETE CASCADE,
  FOREIGN KEY (idPublicacion) REFERENCES publicacion(idPublicacion) ON DELETE CASCADE
);

-- Tabla de auditoría: usuarioAuditoria
CREATE TABLE usuarioAuditoria (
  idUsuario INT,
  nombre VARCHAR(50) NOT NULL,
  telefono VARCHAR(10) NOT NULL,
  correo VARCHAR(255) NOT NULL,
  administrador BOOLEAN DEFAULT FALSE,
  fechaCreacion DATETIME NOT NULL,
  fechaEdicion DATETIME NOT NULL
);

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS
-- ============================================

DELIMITER $$

-- Procedimiento para insertar un usuario
CREATE PROCEDURE sp_InsertarUsuario (
  IN p_nombre VARCHAR(50),
  IN p_telefono VARCHAR(10),
  IN p_correo VARCHAR(255),
  IN p_contrasenha VARCHAR(255),
  IN p_fechaCreacion DATETIME,
  IN p_administrador BOOLEAN
)
BEGIN
  IF EXISTS (SELECT 1 FROM usuario WHERE nombre = p_nombre) THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'El nombre ya está registrado.';
  ELSEIF EXISTS (SELECT 1 FROM usuario WHERE telefono = p_telefono) THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'El teléfono ya está registrado.';
  ELSEIF EXISTS (SELECT 1 FROM usuario WHERE correo = p_correo) THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'El correo ya está registrado.';
  ELSE
    INSERT INTO usuario (nombre, telefono, correo, contrasenha, fechaCreacion, administrador)
    VALUES (p_nombre, p_telefono, p_correo, p_contrasenha, p_fechaCreacion, p_administrador);
  END IF;
END$$

-- Procedimiento almacenado inicio sesion
CREATE PROCEDURE sp_InicioSesion(IN p_nombre VARCHAR(50))
BEGIN
    SELECT *
    FROM usuario
    WHERE nombre = p_nombre;
END$$

-- Procedimiento para actualizar un usuario
CREATE PROCEDURE sp_ActualizarUsuario (
  IN p_idUsuario INT,
  IN p_nombre VARCHAR(50),
  IN p_telefono VARCHAR(10),
  IN p_correo VARCHAR(255),
  IN p_contrasenha VARCHAR(255),
  IN p_administrador BOOLEAN
)
BEGIN
  IF EXISTS (SELECT 1 FROM usuario WHERE nombre = p_nombre AND idUsuario != p_idUsuario) THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'El nombre ya está registrado.';
  ELSEIF EXISTS (SELECT 1 FROM usuario WHERE telefono = p_telefono AND idUsuario != p_idUsuario) THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'El teléfono ya está registrado.';
  ELSEIF EXISTS (SELECT 1 FROM usuario WHERE correo = p_correo AND idUsuario != p_idUsuario) THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'El correo ya está registrado.';
  ELSE
    UPDATE usuario
    SET nombre = p_nombre,
        telefono = p_telefono,
        correo = p_correo,
        contrasenha = p_contrasenha,
        administrador = p_administrador
    WHERE idUsuario = p_idUsuario;
  END IF;
END$$

-- Procedimiento para eliminar un usuario
CREATE PROCEDURE sp_EliminarUsuario (IN p_idUsuario INT)
BEGIN
  DELETE FROM usuario WHERE idUsuario = p_idUsuario;
END$$

-- Procedimiento para obtener un usuario por nombre
CREATE PROCEDURE sp_ObtenerUsuarioPorNombre (IN p_nombre VARCHAR(50))
BEGIN
  SELECT * FROM usuario WHERE nombre = p_nombre;
END$$

  -- Procedimiento para obtener audotiras por ID
CREATE PROCEDURE sp_ObtenerAuditoriasPorID(IN p_idUsuario INT)
BEGIN
    SELECT *
    FROM usuarioAuditoria
    WHERE idUsuario = p_idUsuario;
END$$

-- Insertar publicación
CREATE PROCEDURE sp_InsertarPublicacion (
  IN p_idAutor INT,
  IN p_contenido TEXT,
  IN p_fechaCreacion DATETIME
)
BEGIN
  INSERT INTO publicacion (idAutor, contenido, fechaCreacion)
  VALUES (p_idAutor, p_contenido, p_fechaCreacion);
END$$

-- Actualizar publicación
CREATE PROCEDURE sp_ActualizarPublicacion (
  IN p_idPublicacion INT,
  IN p_contenido TEXT
)
BEGIN
  UPDATE publicacion
  SET contenido = p_contenido
  WHERE idPublicacion = p_idPublicacion;
END$$

-- Eliminar publicación
CREATE PROCEDURE sp_EliminarPublicacion (
  IN p_idPublicacion INT
)
BEGIN
  DELETE FROM publicacion
  WHERE idPublicacion = p_idPublicacion;
END$$

-- Obtener publicación por ID
CREATE PROCEDURE sp_ObtenerPublicacionPorID (
  IN p_idPublicacion INT
)
BEGIN
  SELECT * FROM publicacion
  WHERE idPublicacion = p_idPublicacion;
END$$

-- Obtener publicaciones por autor nombre
CREATE PROCEDURE sp_ObtenerPublicacionesPorAutorNombre (
  IN p_nombre VARCHAR(50)
)
BEGIN
  SELECT 
    p.idPublicacion,
    p.contenido,
    p.fechaCreacion,
    p.idAutor,
    u.nombre AS nombreAutor
  FROM publicacion p
  INNER JOIN usuario u ON p.idAutor = u.idUsuario
  WHERE u.nombre = p_nombre;
END$$

-- Insertar comentario
CREATE PROCEDURE sp_InsertarComentario (
  IN p_idPublicacion INT,
  IN p_idAutor INT,
  IN p_contenido TEXT,
  IN P_fechaCreacion DATETIME
)
BEGIN
  INSERT INTO comentario (idPublicacion, idAutor, contenido, fechaCreacion)
  VALUES (p_idPublicacion, p_idAutor, p_contenido, p_fechaCreacion);
END$$

-- Actualizar comentario
CREATE PROCEDURE sp_ActualizarComentario (
  IN p_idComentario INT,
  IN p_contenido TEXT
)
BEGIN
  UPDATE comentario
  SET contenido = p_contenido
  WHERE idComentario = p_idComentario;
END$$

-- Eliminar comentario
CREATE PROCEDURE sp_EliminarComentario (
  IN p_idComentario INT
)
BEGIN
  DELETE FROM comentario
  WHERE idComentario = p_idComentario;
END$$

-- Obtener comentarios por publicación
CREATE PROCEDURE sp_ObtenerComentariosPorPublicacion (
  IN p_idPublicacion INT
)
BEGIN
  SELECT * FROM comentario
  WHERE idPublicacion = p_idPublicacion;
END$$

-- ============================================
-- VISTAS
-- ============================================

-- Vista para obtener auditorias
CREATE VIEW View_ObtenerAuditorias AS
SELECT *
FROM usuarioAuditoria;

-- Vista para obtener todas las publicaciones
CREATE OR REPLACE VIEW View_ObtenerPublicaciones AS
SELECT 
    p.idPublicacion,
    p.contenido,
    p.fechaCreacion,
    p.idAutor,
    u.nombre AS nombreAutor
FROM 
    publicacion p
JOIN 
    usuario u ON p.idAutor = u.idUsuario$$


-- Vista para obtener todos los comentarios
CREATE OR REPLACE VIEW View_ObtenerComentarios AS
SELECT 
    c.idComentario,
    c.idPublicacion,
    c.idAutor,
    u.nombre AS nombreAutor,
    c.contenido,
    c.fechaCreacion
FROM 
    comentario c
JOIN 
    usuario u ON c.idAutor = u.idUsuario$$

-- ============================================
-- TRIGGERS
-- ============================================

-- Trigger al insertar usuario
CREATE TRIGGER trg_UsuarioInsertado
AFTER INSERT ON usuario
FOR EACH ROW
BEGIN
  INSERT INTO usuarioAuditoria (
    idUsuario, nombre, telefono, correo, fechaCreacion, fechaEdicion, administrador
  )
  VALUES (
    NEW.idUsuario, NEW.nombre, NEW.telefono, NEW.correo, NEW.fechaCreacion, NOW(), NEW.administrador
  );
END$$

-- Trigger al modificar usuario
CREATE TRIGGER trg_UsuarioModificado
AFTER UPDATE ON usuario
FOR EACH ROW
BEGIN
  IF OLD.nombre != NEW.nombre OR
     OLD.telefono != NEW.telefono OR
     OLD.correo != NEW.correo OR
     OLD.administrador != NEW.administrador THEN

    INSERT INTO usuarioAuditoria (
      idUsuario, nombre, telefono, correo, fechaCreacion, fechaEdicion, administrador
    )
    VALUES (
      NEW.idUsuario, NEW.nombre, NEW.telefono, NEW.correo, NEW.fechaCreacion, NOW(), NEW.administrador
    );
  END IF;
END$$

-- Trigger al eliminar usuario
CREATE TRIGGER trg_UsuarioEliminado
AFTER DELETE ON usuario
FOR EACH ROW
BEGIN
  INSERT INTO usuarioAuditoria (
    idUsuario, nombre, telefono, correo, fechaCreacion, fechaEdicion, administrador
  )
  VALUES (
    OLD.idUsuario, OLD.nombre, OLD.telefono, OLD.correo, OLD.fechaCreacion, NOW(), OLD.administrador
  );
END$$

DELIMITER ;
