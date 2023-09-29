using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealtClinic.API.Migrations
{
    /// <inheritdoc />
    public partial class Health : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinica",
                columns: table => new
                {
                    IdClinica = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CNPJ = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    RazaoSocial = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    HorarioAbertura = table.Column<TimeOnly>(type: "time", nullable: false),
                    HorarioEncerramento = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinica", x => x.IdClinica);
                });

            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    IdEspecialidade = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Especialidades = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.IdEspecialidade);
                });

            migrationBuilder.CreateTable(
                name: "Prontuario",
                columns: table => new
                {
                    IdProntuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tituloDaConsulta = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    DescProntuario = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prontuario", x => x.IdProntuario);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuario",
                columns: table => new
                {
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    titulo = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuario", x => x.IdTipoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Gestão",
                columns: table => new
                {
                    IdGestão = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gestão", x => x.IdGestão);
                    table.ForeignKey(
                        name: "FK_Gestão_TipoUsuario_IdTipoUsuario",
                        column: x => x.IdTipoUsuario,
                        principalTable: "TipoUsuario",
                        principalColumn: "IdTipoUsuario",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    IdMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Especialidade = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Salario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CRM = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Idade = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEspecialidade = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.IdMedico);
                    table.ForeignKey(
                        name: "FK_Medico_Especialidade_IdEspecialidade",
                        column: x => x.IdEspecialidade,
                        principalTable: "Especialidade",
                        principalColumn: "IdEspecialidade",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Medico_TipoUsuario_IdTipoUsuario",
                        column: x => x.IdTipoUsuario,
                        principalTable: "TipoUsuario",
                        principalColumn: "IdTipoUsuario",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    IdPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    SoBreNome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    DataDeNascimento = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Sexo = table.Column<bool>(type: "BIT", nullable: false),
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.IdPaciente);
                    table.ForeignKey(
                        name: "FK_Paciente_TipoUsuario_IdTipoUsuario",
                        column: x => x.IdTipoUsuario,
                        principalTable: "TipoUsuario",
                        principalColumn: "IdTipoUsuario",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    SobreNome = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_TipoUsuario_IdTipoUsuario",
                        column: x => x.IdTipoUsuario,
                        principalTable: "TipoUsuario",
                        principalColumn: "IdTipoUsuario");
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    IdConsulta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProntuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.IdConsulta);
                    table.ForeignKey(
                        name: "FK_Consulta_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Consulta_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Consulta_Prontuario_IdProntuario",
                        column: x => x.IdProntuario,
                        principalTable: "Prontuario",
                        principalColumn: "IdProntuario",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    IdFeedback = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdConsulta = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.IdFeedback);
                    table.ForeignKey(
                        name: "FK_Feedback_Consulta_IdConsulta",
                        column: x => x.IdConsulta,
                        principalTable: "Consulta",
                        principalColumn: "IdConsulta",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Feedback_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Feedback_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_IdMedico",
                table: "Consulta",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_IdPaciente",
                table: "Consulta",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_IdProntuario",
                table: "Consulta",
                column: "IdProntuario");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_IdConsulta",
                table: "Feedback",
                column: "IdConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_IdPaciente",
                table: "Feedback",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_IdUsuario",
                table: "Feedback",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Gestão_IdTipoUsuario",
                table: "Gestão",
                column: "IdTipoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_IdEspecialidade",
                table: "Medico",
                column: "IdEspecialidade");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_IdTipoUsuario",
                table: "Medico",
                column: "IdTipoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_IdTipoUsuario",
                table: "Paciente",
                column: "IdTipoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Email",
                table: "Usuario",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdTipoUsuario",
                table: "Usuario",
                column: "IdTipoUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clinica");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Gestão");

            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Prontuario");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "TipoUsuario");
        }
    }
}
