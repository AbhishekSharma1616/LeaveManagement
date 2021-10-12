namespace prototype_four.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTeamData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Teams(TeamName)Values('IT')");
            Sql("Insert into Teams(TeamName)Values('HR')");
            Sql("Insert into Teams(TeamName)Values('Talent Acquisition')");
            Sql("Insert into Teams(TeamName)Values('Training & Development')");
        }
        
        public override void Down()
        {
        }
    }
}
