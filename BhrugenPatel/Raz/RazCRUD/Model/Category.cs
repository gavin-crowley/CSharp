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
        public int DisplayOrder { get; set; }

    }
}
