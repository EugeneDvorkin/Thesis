namespace Teplo.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondCalc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CanalM1994",
                c => new
                    {
                        ID_CM = c.Int(nullable: false, identity: true),
                        D_CM = c.Int(nullable: false),
                        Q35_10_CM = c.Double(nullable: false),
                        Q85_60_CM = c.Double(nullable: false),
                        Q135_110_CM = c.Double(nullable: false),
                        Q185_160_CM = c.Double(nullable: false),
                        Q235_210_CM = c.Double(nullable: false),
                        Q285_260_CM = c.Double(nullable: false),
                        Q335_310_CM = c.Double(nullable: false),
                        Q385_360_CM = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID_CM);
            
            CreateTable(
                "dbo.CanalU1994",
                c => new
                    {
                        ID_CU = c.Int(nullable: false, identity: true),
                        D_CU = c.Int(nullable: false),
                        Q10_CU = c.Double(nullable: false),
                        Q60_CU = c.Double(nullable: false),
                        Q160_CU = c.Double(nullable: false),
                        Q260_CU = c.Double(nullable: false),
                        Q360_CU = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID_CU);
            
            CreateTable(
                "dbo.RoomU1994",
                c => new
                    {
                        ID_RU = c.Int(nullable: false, identity: true),
                        D_RU = c.Int(nullable: false),
                        Q35_RU = c.Double(nullable: false),
                        Q85_RU = c.Double(nullable: false),
                        Q185_RU = c.Double(nullable: false),
                        Q285_RU = c.Double(nullable: false),
                        Q385_RU = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID_RU);
            
            CreateTable(
                "dbo.SteamM1994",
                c => new
                    {
                        ID_M = c.Int(nullable: false, identity: true),
                        Dp_M = c.Int(nullable: false),
                        Dk_M = c.Int(nullable: false),
                        Qk_M = c.Double(nullable: false),
                        Q110_M = c.Double(nullable: false),
                        Q145_M = c.Double(nullable: false),
                        Q195_M = c.Double(nullable: false),
                        Q245_M = c.Double(nullable: false),
                        Q295_M = c.Double(nullable: false),
                        Q345_M = c.Double(nullable: false),
                        Q395_M = c.Double(nullable: false),
                        Q445_M = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID_M);
            
            CreateTable(
                "dbo.SteamU1994",
                c => new
                    {
                        ID_U = c.Int(nullable: false, identity: true),
                        Dp_U = c.Int(nullable: false),
                        Dk_U = c.Int(nullable: false),
                        Qk_U = c.Double(nullable: false),
                        Q110_U = c.Double(nullable: false),
                        Q145_U = c.Double(nullable: false),
                        Q195_U = c.Double(nullable: false),
                        Q245_U = c.Double(nullable: false),
                        Q295_U = c.Double(nullable: false),
                        Q345_U = c.Double(nullable: false),
                        Q395_U = c.Double(nullable: false),
                        Q445_U = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID_U);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SteamU1994");
            DropTable("dbo.SteamM1994");
            DropTable("dbo.RoomU1994");
            DropTable("dbo.CanalU1994");
            DropTable("dbo.CanalM1994");
        }
    }
}
