namespace Finance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _int : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Receitas",
                c => new
                    {
                        ReceitaId = c.Int(nullable: false, identity: true),
                        Receita_Nome = c.Int(nullable: false),
                        Data_Entrada = c.DateTime(nullable: false),
                        Receita_Valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ReceitaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Receitas");
        }
    }
}
