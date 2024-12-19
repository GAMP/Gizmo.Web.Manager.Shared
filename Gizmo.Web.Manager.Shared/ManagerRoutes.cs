namespace Gizmo.Web.Manager.Shared
{
    public static class ManagerRoutes
    {
        public const string SignIn = "/signin";
        public const string SelectBranch = "/selectbranch";
        public const string SelectRegister = "/selectregister";
        public const string ShiftStartRoute = "/shiftstart";
        public const string ShiftEndConfirmationRoute = "/shiftendconfirmation";
        public const string ShiftEndRoute = "/shiftend";

        public const string Home = "/";
        public const string Start = "/start";
        public const string Hosts = "/hosts";
        public const string POS = "/pos";
        public const string POSPayments = "/pospayments";
        public const string User = "/user";
        public const string UserEdit = "/user/edit";
        public const string Users = "/user/list";
        public const string UserGroup = "/usergroup";
        public const string Reservation = "/reservation";
        public const string Monitoring = "/monitoring";
        public const string Logs = "/logs";
        public const string Reports = "/reports";
        public const string Orders = "/orders";
        public const string OrdersPayments = "/orderspayments";
        public const string OrdersDelivery = "/ordersdelivery";

        public const string WaitingLines = "/waitinglines";

        public const string SettingsHostsBase = "/settings/hosts";
        public const string SettingsHostsComputers = "/settings/hosts/computers";
        public const string SettingsHostsComputer = "/settings/hosts/computer";
        public const string SettingsHostsEndpoints = "/settings/hosts/endpoints";
        public const string SettingsHostsEndpoint = "/settings/hosts/endpoint";
        public const string SettingsHostsControllers = "/settings/hosts/controllers";
        public const string SettingsHostsController = "/settings/hosts/controller";
        public const string SettingsHostsHostGroups = "/settings/hosts/hostgroups";
        public const string SettingsHostsHostGroup = "/settings/hosts/hostgroup";
        public const string SettingsHostsLayouts = "/settings/hosts/layouts";
        public const string SettingsHostsAppGroups = "/settings/hosts/appgroups";
        public const string SettingsHostsAppGroup = "/settings/hosts/appgroup";
        public const string SettingsAppsApps = "/settings/apps/apps";
        public const string SettingsAppsApp = "/settings/apps/app";
        public const string SettingsAppsAppExe = "/settings/apps/appexe";
        public const string SettingsAppsDeployment = "/settings/apps/deployment";
        public const string SettingsAppsPersonalFile = "/settings/apps/personalfile";
        public const string SettingsAppsTask = "/settings/apps/task";
        public const string SettingsAppsLicense = "/settings/apps/license";

        public const string ConfigurationBase = "/configuration";
        public const string ConfigurationOrganizationGeneral = "/configuration/general";
        public const string ConfigurationOrganizationSubscription = "/configuration/subscription";
        public const string ConfigurationOrganizationTaxesAndCurrency = "/configuration/taxesandcurrency";
        public const string ConfigurationOrganizationBranches = "/configuration/branches";
        public const string ConfigurationOrganizationBranchEdit = "/configuration/branches/edit";
        public const string ConfigurationOrganizationAttributes = "/configuration/attributes";
        public const string ConfigurationOrganizationAttributeEdit = "/configuration/attributes/edit";
        public const string ConfigurationOrganizationCompanions = "/configuration/companions";
        public const string ConfigurationOrganizationCompanionEdit = "/configuration/companions/edit";
        public const string ConfigurationOrganizationRegisters = "/configuration/registers";
        public const string ConfigurationOrganizationRegisterEdit = "/configuration/registers/edit";
        public const string ConfigurationOrganizationOperators = "/configuration/operators";
        public const string ConfigurationOrganizationOperatorEdit = "/configuration/operators/edit";
        public const string ConfigurationOrganizationPermissions = "/configuration/permissions";
        public const string ConfigurationOrganizationPermissionEdit = "/configuration/permissions/edit";
        public const string ConfigurationOrganizationWaitingLines = "/configuration/waitinglines";
        public const string ConfigurationOrganizationAgeRestrictions = "/configuration/agerestrictions";

        public const string DepositVoid = "/depositvoid";
    }
}
