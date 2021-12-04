namespace Finance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedespesa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Despesas", "Tipo_Despesa_Id", "dbo.TipoDespesas");
            DropIndex("dbo.Despesas", new[] { "Tipo_Despesa_Id" });
            DropPrimaryKey("dbo.TipoDespesas");
            AlterColumn("dbo.TipoDespesas", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.TipoDespesas", "Id");
            CreateIndex("dbo.TipoDespesas", "Id");
            AddForeignKey("dbo.TipoDespesas", "Id", "dbo.Despesas", "Despesa_Id");
            DropColumn("dbo.Despesas", "Tipo_Despesa_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Despesas", "Tipo_Despesa_Id", c => c.Int());
            DropForeignKey("dbo.TipoDespesas", "Id", "dbo.Despesas");
            DropIndex("dbo.TipoDespesas", new[] { "Id" });
            DropPrimaryKey("dbo.TipoDespesas");
            AlterColumn("dbo.TipoDespesas", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TipoDespesas", "Id");
            CreateIndex("dbo.Despesas", "Tipo_Despesa_Id");
            AddForeignKey("dbo.Despesas", "Tipo_Despesa_Id", "dbo.TipoDespesas", "Id");
        }
    }
}
