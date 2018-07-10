namespace MVCMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
            AddColumn("dbo.Movies", "Rating", c => c.String());
            DropColumn("dbo.Movies", "Gnere");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Gnere", c => c.String());
            DropColumn("dbo.Movies", "Rating");
            DropColumn("dbo.Movies", "Genre");
        }
    }
}
