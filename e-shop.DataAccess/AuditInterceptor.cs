using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace e_shop.DataAccess;

public class AuditInterceptor : SaveChangesInterceptor
{
    public override InterceptionResult<int> SavingChanges(
        DbContextEventData eventData,
        InterceptionResult<int> result)
    {
        var entries = eventData.Context
            .ChangeTracker
            .Entries()
            .Where(r => r.Entity is IAuditable);

        foreach (var entityEntry in entries)
        {
            var entity = (IAuditable)entityEntry.Entity;
            if (entityEntry.State == EntityState.Added)
            {
                entity.CreatedAt = DateTime.UtcNow;
                entity.CreatedBy = 1;
            }

            if (entityEntry.State == EntityState.Modified)
            {
                entity.UpdatedAt = DateTime.UtcNow;
                entity.UpdatedBy = 1;
            }
        }

        return base.SavingChanges(eventData, result);
    }
}