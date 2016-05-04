using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelos.Alumnos
{
    /// <summary>
    /// All the methods for retrieving, updating and deleting data are implemented in this class file.
    /// The samples below show the finder and specific finder method for Entity1.
    /// </summary>
    public class AlumnoService
    {
        /// <summary>
        /// This is a sample specific finder method for Entity1.
        /// If you want to delete or rename the method think about changing the xml in the BDC model file as well.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Entity1</returns>
        public static Alumno ReadItem(int id)
        {
            //TODO: This is just a sample. Replace this simple sample with valid code.
            Alumno al = new Alumno();
            
            return al;
        }
        /// <summary>
        /// This is a sample finder method for Entity1.
        /// If you want to delete or rename the method think about changing the xml in the BDC model file as well.
        /// </summary>
        /// <returns>IEnumerable of Entities</returns>
        public static IEnumerable<Alumno> ReadList()
        {
            //TODO: This is just a sample. Replace this simple sample with valid code.
            Alumno[] entityList = new Alumno[1];
           
            return entityList;
        }

       

        
    }
}
