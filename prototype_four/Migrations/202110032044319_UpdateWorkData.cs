namespace prototype_four.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateWorkData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Works(WorkId,Description,WorkName,TeamId)" +
               "Values(1,'Complete it','task no 1',1)");


        }

        public override void Down()
        {
        }
    }
}
