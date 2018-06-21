using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpyStore.Models.Entities.Base
{
   public abstract class EntityBase
   {
        public int Id { get; set; }
        public byte[] TimeStamp { get; set; }
   }
}
