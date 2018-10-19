namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondProblemWithPictures : DbMigration
    {
        public override void Up()
        {
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductsPictures", "picture", c => c.String(unicode: false, storeType: "text"));
        }
    }
}
