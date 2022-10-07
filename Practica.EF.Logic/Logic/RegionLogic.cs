using Practica.EF.Entities;
using Practica.EF.Exceptions;
using Practica.EF.Logic.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Logic
{
    public class RegionLogic : BaseLogic
    {
        public string Add(Region aux)
        {
            context.Region.Add(aux);
            context.SaveChanges();
            return "Shippers Added";
        }

        public string Delete(int id)
        {
            try
            {
                var regionDelete = context.Region.First(r => r.RegionID == id);
                context.Region.Remove(regionDelete);
                context.SaveChanges();
                return "Se ha eliminado con exito";
            }
            catch (Exception ex)
            {
                ForeignKeyException foreignKeyException = new ForeignKeyException("Error");
                return foreignKeyException.Message;
            }
        }

        public List<Region> GetAll()
        {
            return context.Region.ToList();
        }

        public void Update(Region region)
        {
            try
            {
                var regionUpdate = context.Region.Find(region.RegionID);
                regionUpdate.RegionDescription = region.RegionDescription;
                context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
