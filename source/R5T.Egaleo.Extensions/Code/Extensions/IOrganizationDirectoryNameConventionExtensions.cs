using System;

using R5T.Ostrogothia;


namespace R5T.Egaleo.Extensions
{
    public static class IOrganizationDirectoryNameConventionExtensions
    {
        public static string GetOrganizationDirectoryName(this IOrganizationDirectoryNameConvention convention, IOrganization organization)
        {
            var organizationDirectoryName = convention.GetOrganizationDirectoryName(organization.Name);
            return organizationDirectoryName;
        }
    }
}
