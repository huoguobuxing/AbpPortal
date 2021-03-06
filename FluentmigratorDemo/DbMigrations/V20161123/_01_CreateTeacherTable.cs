﻿using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.

namespace FluentmigratorDemo.DbMigrations.V20161123
{
    [Profile("Development")]
    [Migration(201611231)]
    public class _01_CreateTeacherTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("T_Teacher")

                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Name").AsString(255).NotNullable();

            Create.Table("T_Course")
               .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
               .WithColumn("Name").AsString(255).NotNullable()
               .WithColumn("Teacher_Id").AsInt32().ForeignKey("T_teacher", "Id");
        }
        public override void Down()
        {
            Delete.Table("T_Teacher");
        }
    }
}
