using EfCore.Shaman.ModelScanner;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCore.Shaman
{
    public interface IFixMigrationUpService : IShamanService
    {
        #region Instance Methods
        void FixMigrationUp(MigrationBuilder migrationBuilder, ModelInfo info);

        #endregion
    }
}