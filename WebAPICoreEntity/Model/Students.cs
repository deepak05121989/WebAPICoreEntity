using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPICoreEntity.Model
{
    [Table(name:"studentDetails")]
    public class Students
    {
        [Key]
        public int Id { get; set; }
        public string? StudentName { get; set; }
        public string? StudentEmail { get; set; }
        public long? StudentMobile { get; set; }
    }
}
