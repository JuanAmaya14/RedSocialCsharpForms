-- NOTA: Los datos son ficticios y no corresponden a personas reales.

-- Insertar usuarios existentes
CALL sp_InsertarUsuario('jperez91', '3000000001', 'jperez91@example.com', 
  '$2a$11$N9qo8uLOickgx2ZMRZo5i.ez1WY/dlCk9RtGx9K9mv.T01h23JwC2', NOW(), FALSE);

CALL sp_InsertarUsuario('mariag_02', '3000000002', 'mariag_02@example.com', 
  '$2a$11$e0MYzXyjpJS7Pd0RVvHwHeFQnWfuUliwLk/KzRZ8B0sIE9Z3Hn9KW', NOW(), FALSE);

CALL sp_InsertarUsuario('csanchez88', '3000000003', 'csanchez88@example.com', 
  '$2a$11$7QmQ4gKcmU0e5PgrY6YlSeUpgJoMTRsAe6Z1oDFx6Pq4FcWjF7ZG2', NOW(), FALSE);

CALL sp_InsertarUsuario('laura_3d', '3000000004', 'laura_3d@example.com', 
  '$2a$11$6ZxP5KjZWnSt4RkxVqF51e9cGv0sHoW6zN6RQoJw7mE3OEbArv9eO', NOW(), FALSE);

CALL sp_InsertarUsuario('ana_dev05', '3000000005', 'ana_dev05@example.com', 
  '$2a$11$6Uv/J8sE09B1qJ7eAYyW6.x4nrrP1XVmNYsPpYQmGJYxOBkQo3wdy', NOW(), FALSE);

-- Insertar 3 usuarios nuevos
CALL sp_InsertarUsuario('pedruiz99', '3000000006', 'pedruiz99@example.com', 
  '$2a$11$9gKWxzIbqxU/zPzNMbZ9mO4OJ7UwGjvBnmu5lV1N7YmSyVVHYjzyi', NOW(), FALSE);

CALL sp_InsertarUsuario('s_torres', '3000000007', 's_torres@example.com', 
  '$2a$11$GfOHnpfZFoUYJWzMhhYKNO8kGbx9G6vYQGz4DdqEGXIoIbFGBGnYe', NOW(), FALSE);

CALL sp_InsertarUsuario('ricky_m', '3000000008', 'ricky_m@example.com', 
  '$2a$11$uKiyTQx0n5mG.QRdt0M86uOMIwl9Zon1Mk3NaU7UElYt1cWaQBLuC', NOW(), FALSE);

-- Publicaciones
CALL sp_InsertarPublicacion(1, 'Mi primera publicación sobre SQL', NOW());
CALL sp_InsertarPublicacion(1, 'Compartiendo ideas sobre procedimientos almacenados', NOW());
CALL sp_InsertarPublicacion(2, 'Hola, este es mi post inicial.', NOW());
CALL sp_InsertarPublicacion(3, '¿Qué opinan del diseño relacional?', NOW());
CALL sp_InsertarPublicacion(4, 'Aprendiendo triggers en MySQL', NOW());
CALL sp_InsertarPublicacion(5, 'Comunidad de desarrolladores, únanse.', NOW());
CALL sp_InsertarPublicacion(6, 'Problemas comunes en JOINs', NOW());
CALL sp_InsertarPublicacion(7, 'Documentación eficiente en proyectos', NOW());
CALL sp_InsertarPublicacion(8, 'Errores comunes en MySQL', NOW());

-- Comentarios
-- Publicaciones de jperez91
CALL sp_InsertarComentario(1, 2, 'Buen post, Juan!', NOW());
CALL sp_InsertarComentario(1, 3, 'Gracias por compartir.', NOW());
CALL sp_InsertarComentario(2, 5, 'Muy útil, gracias.', NOW());

-- Publicación de mariag_02
CALL sp_InsertarComentario(3, 1, 'Bienvenida María.', NOW());

-- Publicación de csanchez88
CALL sp_InsertarComentario(4, 4, 'Estoy de acuerdo contigo.', NOW());
CALL sp_InsertarComentario(4, 5, '¿Tienes ejemplos?', NOW());

-- Publicación de laura_3d
CALL sp_InsertarComentario(5, 3, 'Trigger me salvó el proyecto.', NOW());

-- Publicación de ana_dev05
CALL sp_InsertarComentario(6, 1, '¡Cuenta conmigo!', NOW());
CALL sp_InsertarComentario(6, 2, 'Me encanta la idea.', NOW());

-- Nuevas publicaciones (pedruiz99, s_torres, ricky_m)
CALL sp_InsertarComentario(7, 1, 'Buen resumen de errores!', NOW());
CALL sp_InsertarComentario(8, 5, 'Totalmente cierto, documentar ahorra tiempo.', NOW());
CALL sp_InsertarComentario(9, 6, '¡Me ha pasado muchas veces!', NOW());

-- Actualización de usuarios
CALL sp_ActualizarUsuario(1, 'jperez_actual', '3000000010', 'jperez_actual@example.com', 
  '$2a$11$zOZcGxG7HReSJe5nd7x3AuTE5pOdG/qULmsw/Imv4DMTDC8MvDL5m', FALSE);

CALL sp_ActualizarUsuario(2, 'mariag_02', '3000000002', 'maria_2025@example.com', 
  '$2a$11$B9m6uB3w3l6.qCU6gtgqJ.QZZYpPApTDb6Us3Ad0Z3COwPfzDs8hK', FALSE);

-- Eliminaciones
CALL sp_EliminarUsuario(3); -- Eliminar a csanchez88
CALL sp_EliminarPublicacion(5); -- Eliminar publicación de laura_3d

