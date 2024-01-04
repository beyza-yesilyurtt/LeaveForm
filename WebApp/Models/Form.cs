using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Form
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public DateTime PermissionStartDate  { get; set; }
        public DateTime PermissionEndDate { get; set; }
        public string? PermissionReason { get; set; }
        
    }
}
