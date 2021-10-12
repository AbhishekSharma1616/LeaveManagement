namespace prototype_four.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLeaveData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Leaves(LeaveDescription,fromTo,Useremail,Checked,LeaveTypeId)" + 
                "Values('suffering from fever','10th to 15th','Abhishek',1,1)");

        }

        public override void Down()
        {
        }
    }
}
