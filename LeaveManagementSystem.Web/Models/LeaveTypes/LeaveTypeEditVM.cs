using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeEditVM
    {
        public int Id { get; set; }

        [Required]
        [Length(4, 150, ErrorMessage = "Error largo de texto")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1, 90)]
        public int Days { get; set; }
    }
}
