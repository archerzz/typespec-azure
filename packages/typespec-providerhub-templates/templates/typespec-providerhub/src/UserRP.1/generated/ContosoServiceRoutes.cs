// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated />

namespace Microsoft.Contoso.Service.Controllers
{
    public static class ContosoServiceRoutes
    {
        public const string Namespace = "Microsoft.Contoso";

        public const string EmployeeItem = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Contoso/Employees/{EmployeeName}";
        public const string EmployeeValidateRead = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Contoso/Employees/{EmployeeName}/resourceReadValidate";
        public const string EmployeeBeginRead = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Contoso/Employees/{EmployeeName}/resourceReadBegin";
        public const string EmployeeValidateCreate = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Contoso/Employees/{EmployeeName}/resourceCreationValidate";
        public const string EmployeeEndCreate = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Contoso/Employees/{EmployeeName}/resourceCreationCompleted";
        public const string EmployeeValidatePatch = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Contoso/Employees/{EmployeeName}/resourcePatchValidate";
        public const string EmployeeEndPatch = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Contoso/Employees/{EmployeeName}/resourcePatchCompleted";
        public const string EmployeeValidateDelete = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Contoso/Employees/{EmployeeName}/resourceDeletionValidate";
        public const string EmployeeEndDelete = "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Contoso/Employees/{EmployeeName}/resourceDeletionCompleted";
        public const string EmployeeSubscriptionLifeCycleNotification = "/subscriptions/{subscriptionId}/providers/Microsoft.Contoso/Employees/subscriptionLifeCycleNotification";
    }
}