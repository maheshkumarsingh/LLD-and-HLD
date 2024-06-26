﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class GetPersonsSP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sp_GetAllPersons = @"
                  CREATE PROCEDURE [dbo].[GetAllPersons]
                  AS
                  BEGIN
	              SET NOCOUNT ON;
	              SELECT PersonID, 
                    PersonName, 
                    Email, DateOfBirth, Gender, CountryID, Address, ReceiveNewsLetters FROM [dbo].[Persons];
                  END
                  GO";
            migrationBuilder.Sql(sp_GetAllPersons);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string sp_DropGetAllPersons = @"DROP PROCEDURE [dbo].[GetAllPersons]";
            migrationBuilder.Sql(sp_DropGetAllPersons);
        }
    }
}
