﻿// Copyright Finbuckle LLC, Andrew White, and Contributors.
// Refer to the solution LICENSE file for more information.

namespace Finbuckle.MultiTenant.EntityFrameworkCore
{
    public interface IMultiTenantDbContext
    {
        ITenantInfo? TenantInfo { get; }
        TenantMismatchMode TenantMismatchMode { get; }
        TenantNotSetMode TenantNotSetMode { get; }
    }
}