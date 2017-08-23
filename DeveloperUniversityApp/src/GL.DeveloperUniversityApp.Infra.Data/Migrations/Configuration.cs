using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace GL.DeveloperUniversityApp.Infra.Data.Migrations
{


    internal sealed class Configuration : DbMigrationsConfiguration<Context.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.SchoolContext context)
        {

        }
    }
}
