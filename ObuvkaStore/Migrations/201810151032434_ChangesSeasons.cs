namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesSeasons : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ProductsInfo", new[] { "Seasons_id" });
            DropColumn("dbo.ProductsInfo", "idSeason");
            RenameColumn(table: "dbo.ProductsInfo", name: "Seasons_id", newName: "idSeason");
            AlterColumn("dbo.ProductsInfo", "idSeason", c => c.Int(nullable: false));
            AlterColumn("dbo.Seasons", "season", c => c.String(nullable: false, maxLength: 50, unicode: false));
            CreateIndex("dbo.ProductsInfo", "idSeason");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ProductsInfo", new[] { "idSeason" });
            AlterColumn("dbo.Seasons", "season", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.ProductsInfo", "idSeason", c => c.Int());
            RenameColumn(table: "dbo.ProductsInfo", name: "idSeason", newName: "Seasons_id");
            AddColumn("dbo.ProductsInfo", "idSeason", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductsInfo", "Seasons_id");
        }
    }
}
