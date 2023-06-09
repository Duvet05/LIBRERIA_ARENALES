DROP PROCEDURE IF EXISTS INSERTAR_PRODUCTO;
DROP PROCEDURE IF EXISTS ACTUALIZAR_PRODUCTO;
DROP PROCEDURE IF EXISTS ELIMINAR_PRODUCTO;
DROP PROCEDURE IF EXISTS LISTAR_PRODUCTO_POR_NOMBRE_CATEGORIA_MARCA;
DROP PROCEDURE IF exists INSERTAR_ORDEN_COMPRA;
DROP PROCEDURE IF exists ACTUALIZAR_ORDEN_COMPRA;
DROP PROCEDURE IF exists ELIMINAR_ORDEN_COMPRA;
DROP PROCEDURE IF exists LISTAR_ORDENES_COMPRA_X_ID_NOMBRE_DNI_EMPLEADO;
DROP PROCEDURE IF exists INSERTAR_LINEA_ORDEN_COMPRA;
DROP PROCEDURE IF exists LISTAR_LINEAS_ORDEN_COMPRA_X_ID_ORDEN_COMPRA;
DROP PROCEDURE IF exists LISTAR_CATEGORIA_TODAS;
DROP PROCEDURE IF exists LISTAR_MARCA_TODAS;
DROP PROCEDURE IF EXISTS INSERTAR_PROMOCION;
DROP PROCEDURE IF EXISTS MODIFICAR_PROMOCION;
DROP PROCEDURE IF EXISTS ELIMINAR_PROMOCION;
DROP PROCEDURE IF EXISTS LISTAR_PROMOCION_POR_NOMBRE;
	
DELIMITER $
create procedure LISTAR_CATEGORIA_TODAS()
begin
	select id_categoria, descripcion
    from categoria
    where activo = 1;
end $

create procedure LISTAR_MARCA_TODAS()
begin
	select id_marca, descripcion
    from marca
    where activo = 1;
end $

drop procedure if exists INSERTAR_PRODUCTO;
delimiter $
CREATE PROCEDURE INSERTAR_PRODUCTO(
	OUT _id_producto INT,
    IN _fid_categoria INT,
    IN _fid_marca INT,
    IN _nombre VARCHAR(50),
    IN _precio DECIMAL(10, 2),
    IN _precio_por_mayor DECIMAL(10, 2),
    IN _foto LONGBLOB
)
BEGIN
    INSERT INTO producto (fid_categoria, fid_marca, nombre, precio, precio_por_mayor, foto)
    VALUES (_fid_categoria, _fid_marca, _nombre, _precio, _precio_por_mayor, _foto);
    set _id_producto = @@last_insert_id;
    
    INSERT INTO sedeXproducto(fid_sede, fid_producto, stock, activo) values (1,@@last_insert_id,0,1);
END$
DELIMITER $

CREATE PROCEDURE ACTUALIZAR_PRODUCTO(
    IN _id_producto INT,
    IN _fid_categoria INT,
    IN _fid_marca INT,
    IN _nombre VARCHAR(50),
    IN _precio DECIMAL(10, 2),
    IN _precio_por_mayor DECIMAL(10, 2),
    IN _foto LONGBLOB
)
BEGIN
    UPDATE producto
    SET fid_categoria = _fid_categoria,fid_marca = _fid_marca,nombre = _nombre, precio = _precio,precio_por_mayor = _precio_por_mayor,foto = _foto
    WHERE id_producto = _id_producto;
END$

DELIMITER $
CREATE PROCEDURE ELIMINAR_PRODUCTO(
	IN _id_producto INT
)
BEGIN
	UPDATE producto SET activo = 0 where id_producto = _id_producto;
END$

drop procedure IF EXISTS LISTAR_PRODUCTO_POR_NOMBRE_CATEGORIA_MARCA;
DELIMITER $
CREATE PROCEDURE LISTAR_PRODUCTO_POR_NOMBRE_CATEGORIA_MARCA(
	IN _nombre VARCHAR(100),
    IN _fid_categoria int,
    IN _fid_marca int
)
BEGIN
	if (_fid_categoria = -1 and _fid_marca = -1) then
		
		SELECT p.id_producto,p.nombre ,c.id_categoria, c.descripcion AS nombre_categoria, 
			m.id_marca , m.descripcion AS nombre_marca,
			p.precio_por_mayor,p.precio, p.foto
		FROM producto p
		INNER JOIN categoria c ON p.fid_categoria = c.id_categoria 
		INNER JOIN marca m ON p.fid_marca = m.id_marca
		WHERE p.activo = 1 AND 
		nombre LIKE CONCAT('%',_nombre,'%');
	elseif (_fid_categoria = -1 and _fid_marca != -1) then
		SELECT p.id_producto,p.nombre ,c.id_categoria, c.descripcion AS nombre_categoria, 
			m.id_marca , m.descripcion AS nombre_marca,
			p.precio_por_mayor,p.precio, p.foto
		FROM producto p
		INNER JOIN categoria c ON p.fid_categoria = c.id_categoria 
		INNER JOIN marca m ON p.fid_marca = m.id_marca
		WHERE p.activo = 1 AND 
		nombre LIKE CONCAT('%',_nombre,'%') and m.id_marca = _fid_marca;
		
    elseif (_fid_categoria != -1 and _fid_marca = -1) then
		SELECT p.id_producto,p.nombre ,c.id_categoria, c.descripcion AS nombre_categoria, 
			m.id_marca , m.descripcion AS nombre_marca,
			p.precio_por_mayor,p.precio, p.foto
		FROM producto p
		INNER JOIN categoria c ON p.fid_categoria = c.id_categoria 
		INNER JOIN marca m ON p.fid_marca = m.id_marca
		WHERE p.activo = 1 AND 
		nombre LIKE CONCAT('%',_nombre,'%') and c.id_categoria= _fid_categoria;
    
    elseif (_fid_categoria != -1 and _fid_marca != -1) then
		SELECT p.id_producto,p.nombre ,c.id_categoria, c.descripcion AS nombre_categoria, 
			m.id_marca , m.descripcion AS nombre_marca,
			p.precio_por_mayor,p.precio, p.foto
		FROM producto p
		INNER JOIN categoria c ON p.fid_categoria = c.id_categoria 
		INNER JOIN marca m ON p.fid_marca = m.id_marca
		WHERE p.activo = 1 AND 
		nombre LIKE CONCAT('%',_nombre,'%') and m.id_marca = _fid_marca and c.id_categoria = _fid_categoria;
    end if;
END $
-- ORDEN DE COMPRA
drop procedure if exists INSERTAR_ORDEN_COMPRA;
DELIMITER $
CREATE PROCEDURE INSERTAR_ORDEN_COMPRA(
	OUT _id_orden_de_compra INT,
    IN _fid_empleado INT,
    IN _fid_proveedor INT,
    IN _fecha_orden DATE,
    IN _total DECIMAL(10, 2)
)
BEGIN
    INSERT INTO ordenDeCompra (fid_empleado, fid_proveedor, fecha_orden, total, estado)
    VALUES (_fid_empleado, _fid_proveedor, _fecha_orden, _total, "EN PROCESO");
	SET _id_orden_de_compra = @@last_insert_id;
END$
DELIMITER $

drop procedure if exists ACTUALIZAR_ORDEN_COMPRA;
DELIMITER $
CREATE PROCEDURE ACTUALIZAR_ORDEN_COMPRA(
    IN _id_orden_de_compra INT,
    IN _fid_empleado INT,
    IN _total DECIMAL(10, 2),
    in _estado varchar(50)
)
BEGIN
    UPDATE ordenDeCompra
    SET fid_empleado = _fid_empleado,
        total = _total, estado = _estado
    WHERE id_orden_de_compra = _id_orden_de_compra;
    
    UPDATE lineaOrdenDeCompra SET activo = 0 WHERE fid_orden_de_compra = _id_orden_de_compra;
END $


drop procedure if exists CANCELAR_ORDEN_COMPRA;
DELIMITER $
CREATE PROCEDURE CANCELAR_ORDEN_COMPRA(
	IN _id_orden_de_compra INT
)
BEGIN
	UPDATE ordenDeCompra SET estado = "CANCELADO" where id_orden_de_compra = _id_orden_de_compra;
    
END$


drop procedure if exists ACTUALIZAR_ORDEN_COMPRA_RECIBIDA;
DELIMITER $
CREATE PROCEDURE ACTUALIZAR_ORDEN_COMPRA_RECIBIDA(
	IN _id_orden_de_compra INT
)
BEGIN
	UPDATE ordenDeCompra SET estado = "RECIBIDO" where id_orden_de_compra = _id_orden_de_compra;
END$

DROP PROCEDURE IF EXISTS LISTAR_ORDENES_COMPRA_X_PROVEEDOR;
DELIMITER $
CREATE PROCEDURE LISTAR_ORDENES_COMPRA_X_PROVEEDOR(
    IN _id_proveedor INT, /*Considerar -1 para cuando queremos listar todos*/
    in _fecha_inicio date,
    in _fecha_fin date,
    in _estado varchar(50)
)
BEGIN
    if (_estado = "TODOS" and _id_proveedor = -1) then
		SELECT oc.id_orden_de_compra,oc.fecha_orden, oc.fid_empleado, oc.fid_proveedor, oc.total, oc.estado, 
				p.nombre, p.RUC, p.telefono, p.direccion
		FROM ordenDeCompra oc
		INNER JOIN proveedor p ON p.id_proveedor = oc.fid_proveedor
		WHERE p.activo = true
			AND DATE(oc.fecha_orden) >= DATE(_fecha_inicio) AND DATE(oc.fecha_orden) <= DATE(_fecha_fin)
		ORDER BY oc.fecha_orden DESC;
	elseif (_estado = "TODOS" and _id_proveedor != -1) then
		SELECT oc.id_orden_de_compra,oc.fecha_orden, oc.fid_empleado, oc.fid_proveedor, oc.total, oc.estado, 
				p.nombre, p.RUC, p.telefono, p.direccion
		FROM ordenDeCompra oc
		INNER JOIN proveedor p ON p.id_proveedor = oc.fid_proveedor
		WHERE p.activo = true
			AND p.id_proveedor = _id_proveedor 
			AND DATE(oc.fecha_orden) >= DATE(_fecha_inicio) AND DATE(oc.fecha_orden) <= DATE(_fecha_fin)
		ORDER BY oc.fecha_orden DESC;
	elseif (_estado != "TODOS" and _id_proveedor = -1) then
		SELECT oc.id_orden_de_compra,oc.fecha_orden, oc.fid_empleado, oc.fid_proveedor, oc.total, oc.estado, 
				p.nombre, p.RUC, p.telefono, p.direccion
		FROM ordenDeCompra oc
		INNER JOIN proveedor p ON p.id_proveedor = oc.fid_proveedor
		WHERE
			oc.estado = _estado AND p.activo = true
			
			AND DATE(oc.fecha_orden) >= DATE(_fecha_inicio) AND DATE(oc.fecha_orden) <= DATE(_fecha_fin)
		ORDER BY oc.fecha_orden DESC;
	else 
		SELECT oc.id_orden_de_compra,oc.fecha_orden, oc.fid_empleado, oc.fid_proveedor, oc.total, oc.estado, 
				p.nombre, p.RUC, p.telefono, p.direccion
		FROM ordenDeCompra oc
		INNER JOIN proveedor p ON p.id_proveedor = oc.fid_proveedor
		WHERE
			oc.estado = _estado AND p.activo = true
			AND p.id_proveedor = _id_proveedor 
			AND DATE(oc.fecha_orden) >= DATE(_fecha_inicio) AND DATE(oc.fecha_orden) <= DATE(_fecha_fin)
		ORDER BY oc.fecha_orden DESC;
    end if;
END $






-- LINEA ORDEN DE COMPRA 
drop procedure if exists INSERTAR_LINEA_ORDEN_COMPRA;
DELIMITER $
CREATE PROCEDURE INSERTAR_LINEA_ORDEN_COMPRA(
	OUT _id_linea_orden_compra INT,
	IN _fid_orden_de_compra INT,
	IN _fid_producto INT,
	IN _cantidad INT,
	IN _subtotal DECIMAL(10, 2)
)
BEGIN
  INSERT INTO lineaOrdenDeCompra (fid_orden_de_compra, fid_producto, cantidad,subtotal, activo)
  VALUES (_fid_orden_de_compra,_fid_producto,_cantidad,_subtotal, 1);
  SET _id_linea_orden_compra = @@last_insert_id;
END$

drop procedure if exists ACTUALIZAR_STOCK_ALMACEN_PRINCIPAL_POR_LINEA_ORDEN_COMPRA;
DELIMITER $
CREATE PROCEDURE ACTUALIZAR_STOCK_ALMACEN_PRINCIPAL_POR_LINEA_ORDEN_COMPRA(
	IN _fid_producto INT,
	IN _cantidad INT
)
BEGIN
	select stock into @stock_actual_producto from sedeXproducto 
    where fid_sede = 1 and fid_producto = _fid_producto;
    
    UPDATE sedeXproducto SET stock = (@stock_actual_producto + _cantidad) 
    where fid_sede = 1 and fid_producto = _fid_producto;
END$


drop procedure if exists LISTAR_LINEAS_ORDEN_COMPRA_X_ID_ORDEN_COMPRA;
DELIMITER $
CREATE PROCEDURE LISTAR_LINEAS_ORDEN_COMPRA_X_ID_ORDEN_COMPRA(
	IN _id_orden_de_compra INT
)
BEGIN
	SELECT loc.id_linea_orden_compra, loc.cantidad, loc.subtotal, loc.fid_producto,
            p.id_producto, p.nombre,
            pxp.costo,
            m.descripcion marca_descripcion, m.id_marca,
            c.id_categoria, c.descripcion categoria_descripcion
	FROM lineaOrdenDeCompra loc 
	INNER JOIN productoXproveedor pxp ON loc.fid_producto = pxp.fid_producto
    INNER JOIN producto p ON p.id_producto = pxp.fid_producto
    INNER JOIN marca m ON m.id_marca = p.fid_marca
    Inner JOIN categoria c ON c.id_categoria = p.fid_categoria
	WHERE loc.fid_orden_de_compra = _id_orden_de_compra AND loc.activo = 1;
END $

DELIMITER $

CREATE PROCEDURE INSERTAR_PROMOCION(
  OUT _id_promocion INT,
  IN _fid_producto INT,
  IN _porcentaje DECIMAL(10, 2),
  IN _cantidad_minima INT,
  IN _fecha_inicio DATE,
  IN _fecha_fin DATE
)
BEGIN
  INSERT INTO promocion (fid_producto, porcentaje, cantidad_minima, fecha_inicio, fecha_fin)
  VALUES (_fid_producto,_porcentaje,_cantidad_minima,_fecha_inicio,_fecha_fin);
  SET _id_promocion = @@last_insert_id;
END$

DELIMITER $

CREATE PROCEDURE ACTUALIZAR_PROMOCION(
  IN _id_promocion INT,
  IN _fid_producto INT,
  IN _porcentaje DECIMAL(10, 2),
  IN _cantidad_minima INT,
  IN _fecha_inicio DATE,
  IN _fecha_fin DATE
)
BEGIN
  UPDATE promocion
  SET fid_producto = _fid_producto,porcentaje = _porcentaje,cantidad_minima = _cantidad_minima,
      fecha_inicio = _fecha_inicio,fecha_fin = _fecha_fin
  WHERE id_promocion = _id_promocion;
END$

DELIMITER $
CREATE PROCEDURE ELIMINAR_PROMOCION(
	IN _id_promocion INT
)
BEGIN
	UPDATE promocion SET activo = 0 where id_promocion = _id_promocion;
END$

CREATE PROCEDURE LISTAR_PROMOCIONES_POR_NOMBRE_PRODUCTO(
	IN _nombre VARCHAR(50))
BEGIN
    SELECT p.id_promocion ,pr.id_producto ,pr.nombre , p.fecha_inicio ,p.fecha_fin , p.cantidad_minima , p.porcentaje
    FROM promocion p
    INNER JOIN producto pr ON p.fid_producto = pr.id_producto
    WHERE pr.nombre = _nombre;
END$


