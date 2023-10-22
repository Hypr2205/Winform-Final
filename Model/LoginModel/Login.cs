namespace Final.Model.LoginModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string Username { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Password { get; set; }
    }
}
