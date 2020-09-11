namespace SistemaFrame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtoe",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtoe");
        }
    }
}
