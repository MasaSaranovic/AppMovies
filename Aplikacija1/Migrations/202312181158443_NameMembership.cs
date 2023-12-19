namespace Aplikacija1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameMembership : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}