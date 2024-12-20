﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ImoveisApi.Migrations
{
    /// <inheritdoc />
    public partial class Imoveis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Email_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proprietario",
                columns: table => new
                {
                    Id_Proprietario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Proprietario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF_Proprietario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone_Proprietario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietario", x => x.Id_Proprietario);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Vendedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CRECI_Vendedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone_Vendedor = table.Column<int>(type: "int", nullable: false),
                    Email_Vendedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Imovel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proprietario = table.Column<int>(type: "int", nullable: false),
                    Endereco_Imovel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaTotal_Imovel = table.Column<decimal>(type: "decimal(10,3)", precision: 10, scale: 3, nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imovel_Proprietario_Proprietario",
                        column: x => x.Proprietario,
                        principalTable: "Proprietario",
                        principalColumn: "Id_Proprietario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    Id_Contrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imovel = table.Column<int>(type: "int", nullable: false),
                    Cliente = table.Column<int>(type: "int", nullable: false),
                    Data_Inicio = table.Column<DateOnly>(type: "date", nullable: false),
                    Data_Fim = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.Id_Contrato);
                    table.ForeignKey(
                        name: "FK_Contrato_Cliente_Cliente",
                        column: x => x.Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contrato_Imovel_Imovel",
                        column: x => x.Imovel,
                        principalTable: "Imovel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendedorImovel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendedor = table.Column<int>(type: "int", nullable: false),
                    Imovel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendedorImovel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendedorImovel_Imovel_Imovel",
                        column: x => x.Imovel,
                        principalTable: "Imovel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendedorImovel_Vendedor_Vendedor",
                        column: x => x.Vendedor,
                        principalTable: "Vendedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    Id_Pagamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Pagamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor_Pagamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Contrato = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.Id_Pagamento);
                    table.ForeignKey(
                        name: "FK_Pagamento_Contrato_Contrato",
                        column: x => x.Contrato,
                        principalTable: "Contrato",
                        principalColumn: "Id_Contrato",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "CPF", "DataNascimento", "Email_Cliente", "Endereco", "Nome" },
                values: new object[,]
                {
                    { 1, "123.456.789.10", new DateOnly(2002, 10, 10), "cliente@gmail.com", "Av.12a, Araras-SP", "Guilherme" },
                    { 2, "423.391.035-68", new DateOnly(2008, 3, 1), "Marli42@gmail.com", "347 Carvalho Rua, Taubaté, Guiné", "João Lucas Pereira" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_Cliente",
                table: "Contrato",
                column: "Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_Imovel",
                table: "Contrato",
                column: "Imovel");

            migrationBuilder.CreateIndex(
                name: "IX_Imovel_Proprietario",
                table: "Imovel",
                column: "Proprietario");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_Contrato",
                table: "Pagamento",
                column: "Contrato");

            migrationBuilder.CreateIndex(
                name: "IX_VendedorImovel_Imovel",
                table: "VendedorImovel",
                column: "Imovel");

            migrationBuilder.CreateIndex(
                name: "IX_VendedorImovel_Vendedor",
                table: "VendedorImovel",
                column: "Vendedor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "VendedorImovel");

            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Imovel");

            migrationBuilder.DropTable(
                name: "Proprietario");
        }
    }
}
