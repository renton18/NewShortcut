namespace 新ファイル名を指定して実行.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commands",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        alias = c.String(),
                        command = c.String(),
                        commandName = c.String(),
                        commandDetail = c.String(),
                        usedCount = c.Int(nullable: false),
                        updateDateTime = c.DateTime(nullable: false),
                        createDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Commands");
        }
    }
}
