namespace Finance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class despesaetipodespesa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Despesas",
                c => new
                    {
                        Despesa_Id = c.Int(nullable: false, identity: true),
                        Data_Despesa = c.DateTime(nullable: false),
                        Despesa_Valor = c.Double(nullable: false),
                        Tipo_Despesa_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Despesa_Id)
                .ForeignKey("dbo.TipoDespesas", t => t.Tipo_Despesa_Id)
                .Index(t => t.Tipo_Despesa_Id);
            
            CreateTable(
                "dbo.TipoDespesas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Despesas", "Tipo_Despesa_Id", "dbo.TipoDespesas");
            DropIndex("dbo.Despesas", new[] { "Tipo_Despesa_Id" });
            DropTable("dbo.TipoDespesas");
            DropTable("dbo.Despesas");
        }
    }
}
