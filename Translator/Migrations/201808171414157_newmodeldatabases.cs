namespace Translator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmodeldatabases : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Ethnicity", c => c.String());
            AddColumn("dbo.AspNetUsers", "PrimaryLanguage", c => c.String());
            AddColumn("dbo.AspNetUsers", "SecondaryLanguage", c => c.String());
            AddColumn("dbo.AspNetUsers", "LanguageWanted", c => c.String());
            AddColumn("dbo.AspNetUsers", "Province", c => c.String());
            AddColumn("dbo.AspNetUsers", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Country");
            DropColumn("dbo.AspNetUsers", "Province");
            DropColumn("dbo.AspNetUsers", "LanguageWanted");
            DropColumn("dbo.AspNetUsers", "SecondaryLanguage");
            DropColumn("dbo.AspNetUsers", "PrimaryLanguage");
            DropColumn("dbo.AspNetUsers", "Ethnicity");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
