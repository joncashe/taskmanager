using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace ProyectoSaaSCRM.ORM
{ 
    public static class dbEntity
    {
        private static SaaSCRMEntities dbSaaSCRM;


        public static SaaSCRMEntities getSaaSCRMEntity()
        {
            if (dbSaaSCRM == null)
            {
                dbSaaSCRM = new SaaSCRMEntities();
            }

            return dbSaaSCRM;
        }


    }
}