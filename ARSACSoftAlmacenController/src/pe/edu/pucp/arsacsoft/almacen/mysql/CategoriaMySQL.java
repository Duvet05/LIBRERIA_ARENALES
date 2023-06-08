/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.arsacsoft.almacen.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.arsacsoft.almacen.dao.CategoriaDAO;
import pe.edu.pucp.arsacsoft.almacen.model.Categoria;
import pe.edu.pucp.arsacsoft.config.DBManager;

/**
 *
 * @author User
 */
public class CategoriaMySQL implements CategoriaDAO{
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    @Override
    public ArrayList<Categoria> listarTodas() {
            ArrayList<Categoria> categorias = new ArrayList<>();
            try
            {
                con = DBManager.getInstance().getConnection();
                cs = con.prepareCall("{call ()}");
                rs = cs.executeQuery();
                while (rs.next())
                {
                    Categoria categoria = new Categoria();
                    categoria.setIdCategoria(rs.getInt(""));
                    categoria.setDescripcion(rs.getString(""));
                    categorias.add(categoria);
                }
            }catch (Exception ex){
                System.out.println(ex.getMessage());
            }
            finally{
                try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
                try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            }
            return categorias;        
    }
    
}