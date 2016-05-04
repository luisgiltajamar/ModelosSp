using Microsoft.BusinessData.SystemSpecific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.BusinessData.MetadataModel;
using Microsoft.BusinessData.Runtime;
using Microsoft.BusinessData.Infrastructure.SecureStore;
using Microsoft.Office.SecureStoreService.Server;
using Microsoft.SharePoint;
using System.Security;
using System.Runtime.InteropServices;


namespace Modelos.Alumnos
{
      public class AlumnoService:IContextProperty
    {
        public IExecutionContext ExecutionContext { get; set; }

        public ILobSystemInstance LobSystemInstance
        { get; set; }

        public IMethodInstance MethodInstance{ get; set; }

        

        public static void GetCredenciales(out string user,out string pwd)
        {
            var appId = "Alumnos";
            user = "";
            pwd = "";
            ISecureStoreProvider provider = SecureStoreProviderFactory.Create();

            ISecureStoreServiceContext providerContext = provider as ISecureStoreServiceContext;

            providerContext.Context = SPServiceContext.GetContext(new SPSite("http://pruebassp2"));

            using(var creds = provider.GetCredentials(appId))
            {
                if (creds != null)
                {
                    foreach(var c in creds)
                    {
                        if (c.CredentialType == SecureStoreCredentialType.UserName)
                        {
                            user = GetCredentialFromString(c.Credential);
                        }
                        else if (c.CredentialType == SecureStoreCredentialType.Password)
                        {
                            pwd = GetCredentialFromString(c.Credential);
                        }
                    }
                }


            } 

        }

        private static string GetCredentialFromString(SecureString credential)
        {
            if (credential == null)
            {
                return null;
            }
            IntPtr texto = IntPtr.Zero;
            try {
              
                texto = Marshal.SecureStringToBSTR(credential);
                return Marshal.PtrToStringBSTR(texto);
            }
            finally
            {
                if (texto != IntPtr.Zero)
                {
                    Marshal.FreeBSTR(texto);
                }
            }



        }

        public static Alumno ReadItem(int id)
        {
            string pwd = "";
            string user = "";
            GetCredenciales(out user, out pwd);
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
