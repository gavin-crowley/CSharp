using System.ComponentModel.DataAnnotations;

namespace RazCRUD.Model
{
    public class Category // class will be a table in the DB
    {
        // properties are table columns

        [Key] // DA attribute that makes column a primary key
        public int Id { get; set; } // If prop name is already Id, EF makes it primary automatically
        [Required] // makes name required
        public string Name { get; set; }
        [Display(Name ="Display Order")]
        [Range(1,100, ErrorMessage ="Display order must be in range of 1-100!")]
        public int DisplayOrder { get; set; }

    }
}
