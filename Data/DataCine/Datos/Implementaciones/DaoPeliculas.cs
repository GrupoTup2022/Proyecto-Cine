﻿using DataCine.Datos.Interfaces;
using DataCine.Dominio;
using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Datos.Implementaciones
{
    public class DaoPeliculas : IDaoPeliculas
    {
    

        public bool CargarPelicula(Pelicula oPelicula)
        {
            List<Parametro> lParametros = new List<Parametro>();
            lParametros.Add(new Parametro("@titulo_local", oPelicula.Titulo_local));
            lParametros.Add(new Parametro("@titulo_original", oPelicula.Titulo_original));
            lParametros.Add(new Parametro("@descripcion", oPelicula.Descripcion));
            lParametros.Add(new Parametro("@id_pais", oPelicula.pais.Id));
            lParametros.Add(new Parametro("@id_clasificacion", oPelicula.clasificacion.Id));
            lParametros.Add(new Parametro("@fecha_estreno", oPelicula.Fecha_Estreno));
            lParametros.Add(new Parametro("@duracion_min", oPelicula.duracion));
            lParametros.Add(new Parametro("@id_distibuidora", oPelicula.distribuidora.Id));
            lParametros.Add(new Parametro("@id_genero", oPelicula.genero.Id));
            lParametros.Add(new Parametro("@id_directores", oPelicula.director.Id));

            if (HelperDAO.getinstancia().UtilizarProcedimiento("SP_CargarPeliculas", lParametros) > 0)
                return true;
            else
                return false;

        }

        public List<Distribuidora> CargarDistribuidora()
        {
            List<Distribuidora> distribuidoras = new List<Distribuidora>();
            DataTable dt = HelperDAO.getinstancia().ConsultarDB("SP_Distribuidora");

            foreach (DataRow row in dt.Rows)
            {
                Distribuidora dis = new Distribuidora();
                dis.Id = Convert.ToInt32(row[0].ToString());
                dis.Nombre = row[1].ToString();
                distribuidoras.Add(dis);
            }
            return distribuidoras;
        }

        public List<Clasificacion> ObtenerClasificaciones()
        {
            List<Clasificacion> lCla = new List<Clasificacion>();
            DataTable dt = HelperDAO.getinstancia().ConsultarDB("SP_Clasificacion");

            foreach (DataRow row in dt.Rows)
            {
                Clasificacion cla = new Clasificacion();
                cla.Id = Convert.ToInt32(row[0].ToString());
                cla.Nombre = row[1].ToString();
                lCla.Add(cla);
            }
            return lCla;
        }

        public List<Director> ObtenerDirectores()
        {
            List<Director> lDire = new List<Director>();
            DataTable dt = HelperDAO.getinstancia().ConsultarDB("SP_Directores");

            foreach (DataRow row in dt.Rows)
            {
                Director dire = new Director();
                dire.Id = Convert.ToInt32(row[0].ToString());
                dire.Nombre = row[1].ToString();
                lDire.Add(dire);
            }
            return lDire;
        }

        public List<Genero> ObtenerGeneros()
        {
            List<Genero> lGene = new List<Genero>();
            DataTable dt = HelperDAO.getinstancia().ConsultarDB("SP_Genero");

            foreach (DataRow row in dt.Rows)
            {
                Genero gene = new Genero();
                gene.Id = Convert.ToInt32(row[0].ToString());
                gene.Nombre = row[1].ToString();
                lGene.Add(gene);
            }
            return lGene;
        }

        public List<Pais> ObtenerPaises()
        {
            List<Pais> lPais= new List<Pais>();
            DataTable dt = HelperDAO.getinstancia().ConsultarDB("SP_Pais");

            foreach (DataRow row in dt.Rows)
            {
                Pais pais = new Pais();
                pais.Id = Convert.ToInt32(row[0].ToString());
                pais.Nombre = row[1].ToString();
                lPais.Add(pais);
            }
            return lPais;
        }
    }
}
