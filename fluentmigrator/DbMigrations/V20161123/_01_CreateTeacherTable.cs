﻿using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluentmigratorTest.DbMigrations.V20161123
{
    [Profile("Development")]
    public class _01_CreateTeacherTable:FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("T_Teacher")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Name").AsString(255).NotNullable();            
        }
        public override void Down()
        {
            Delete.Table("T_Teacher");
        }
    }
}
