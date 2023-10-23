using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Final.Model.LoginModel {
    public partial class LoginContext : DbContext {
        public LoginContext()
            : base("name=LoginContext") {
        }

        public virtual DbSet<Login> Logins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        }
    }
}
