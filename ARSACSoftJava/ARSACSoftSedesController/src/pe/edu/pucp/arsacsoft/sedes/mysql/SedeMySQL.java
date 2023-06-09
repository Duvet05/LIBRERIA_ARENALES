/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.arsacsoft.sedes.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.arsacsoft.sedes.dao.SedeDAO;
import pe.edu.pucp.arsacsoft.sedes.model.Sede;
import pe.edu.pucp.arsacsoft.config.DBManager;
import pe.edu.pucp.arsacsoft.producto.model.Categoria;
import pe.edu.pucp.arsacsoft.producto.model.Marca;
import pe.edu.pucp.arsacsoft.producto.model.Producto;
import pe.edu.pucp.arsacsoft.sedes.model.SedeXProducto;
/**
 *
 * @author User
 */
public class SedeMySQL implements SedeDAO {
    
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public int insertar(Sede sede) {
        int resultado = 0;
        
        try
        {
            con = DBManager.getInstance().getConnection();
            
            /*
            OUT _idSede INT,
            IN _esAlmacen BOOLEAN,
            IN _direccion VARCHAR(50),
            IN _telefono VARCHAR(50),
            IN _correo VARCHAR(50)
            */
            
            cs = con.prepareCall("{call INSERTAR_SEDE(?,?,?,?)}");
            cs.registerOutParameter(1, java.sql.Types.INTEGER);
            cs.setString(2, sede.getDireccion());
            cs.setString(3, sede.getTelefono());
            cs.setString(4, sede.getCorreo());
            
            cs.executeUpdate();
            sede.setIdSede(cs.getInt("_id_sede"));
            resultado = sede.getIdSede();
            
            for (SedeXProducto sxp : sede.getProductos())
            {
                cs = con.prepareCall("{call INSERTAR_PRODUCTO_EN_SEDE(?,?)}");
                cs.clearParameters();
                cs.setInt(1, sede.getIdSede());
                cs.setInt(2, sxp.getProducto().getIdProducto());
                    
                cs.executeUpdate();
            }
            
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();} catch(Exception ex) {System.out.println(ex.getMessage());}
        }
        return resultado;
        
    }

    @Override
    public ArrayList<Sede> listarTodas() {
        ArrayList<Sede> sedes = new ArrayList<>();
        try
        {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_SEDES()}");
            rs = cs.executeQuery();
            
            while (rs.next())
            {
                Sede sede = new Sede();
                
                sede.setIdSede(rs.getInt("id_sede"));
                sede.setEsPrincipal(rs.getBoolean("es_principal"));
                sede.setCorreo(rs.getString("correo"));
                sede.setDireccion(rs.getString("direccion"));
                sede.setTelefono(rs.getString("telefono"));
                
                sedes.add(sede);
            }
                
            
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        
        return sedes;
    }

    @Override
    public int modificar(Sede sede) {
        int resultado = 0;
        
        try
        {
            con = DBManager.getInstance().getConnection();
            
            cs = con.prepareCall("{call ACTUALIZAR_SEDE(?,?,?,?)}");
            cs.setInt(1, sede.getIdSede());
            cs.setString(2, sede.getDireccion());
            cs.setString(3, sede.getTelefono());
            cs.setString(4, sede.getCorreo());
            
            cs.executeUpdate();
            
            for (SedeXProducto sxp : sede.getProductos())
            {
                cs = con.prepareCall("{call INSERTAR_PRODUCTO_EN_SEDE(?,?)}");
                cs.clearParameters();
                cs.setInt(1, sede.getIdSede());
                cs.setInt(2, sxp.getProducto().getIdProducto());
                cs.executeUpdate();
            }
            
            resultado = 1;
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();} catch(Exception ex) {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<SedeXProducto> listarProductos(int idSede)
    {
        ArrayList<SedeXProducto> productos = new ArrayList<SedeXProducto>();
        
        try
        {
            con = DBManager.getInstance().getConnection();
            
            cs = con.prepareCall("{call LISTAR_PRODUCTOS_DE_SEDE(?)}");
            cs.setInt(1, idSede);
            
            rs = cs.executeQuery();
            
            while (rs.next())
            {
                SedeXProducto sxp = new SedeXProducto();
                
                // p.id_producto, p.nombre, c.descripcion as categoria,
                // m.descripcion as marca, sxp.stock
                
                sxp.setProducto(new Producto());
                sxp.getProducto().setIdProducto(rs.getInt("id_producto"));
                sxp.getProducto().setNombre(rs.getString("nombre"));
                
                sxp.getProducto().setMarca(new Marca());
                sxp.getProducto().getMarca().setDescripcion(rs.getString("marca"));
                
                sxp.getProducto().setCategoria(new Categoria());
                sxp.getProducto().getCategoria().setDescripcion(rs.getString("categoria"));
                
                sxp.setStock(rs.getInt("stock"));
                
                productos.add(sxp);
                
            }
            
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();} catch(Exception ex) {System.out.println(ex.getMessage());}
        }
        return productos;
    }

    @Override
    public ArrayList<SedeXProducto> listarProductosPorNombreMarcaCategoria(int idSede, String nombre, int idMarca, int idCategoria) {
        ArrayList<SedeXProducto> productos = new ArrayList<SedeXProducto>();
        
        try
        {
            con = DBManager.getInstance().getConnection();
            
            cs = con.prepareCall("{call LISTAR_PRODUCTOS_DE_SEDE_POR_NOMBRE_MARCA_CATEGORIA(?,?,?,?)}");
            cs.setInt(1, idSede);
            cs.setString(2, nombre);
            cs.setInt(3, idCategoria);
            cs.setInt(4, idMarca);
            
            rs = cs.executeQuery();
            
            while (rs.next())
            {
                SedeXProducto sxp = new SedeXProducto();
                
                // p.id_producto, p.nombre, c.descripcion as categoria,
                // m.descripcion as marca, sxp.stock
                
                sxp.setProducto(new Producto());
                sxp.getProducto().setIdProducto(rs.getInt("id_producto"));
                sxp.getProducto().setNombre(rs.getString("nombre"));
                
                sxp.getProducto().setMarca(new Marca());
                sxp.getProducto().getMarca().setDescripcion(rs.getString("marca"));
                
                sxp.getProducto().setCategoria(new Categoria());
                sxp.getProducto().getCategoria().setDescripcion(rs.getString("categoria"));
                
                sxp.setStock(rs.getInt("stock"));
                
                productos.add(sxp);
                
            }
            
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();} catch(Exception ex) {System.out.println(ex.getMessage());}
        }
        return productos;
    }

}
