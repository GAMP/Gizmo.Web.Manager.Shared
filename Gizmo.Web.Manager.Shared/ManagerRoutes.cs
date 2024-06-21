namespace Gizmo.Web.Manager.Shared
{
    public static class ManagerRoutes
    {
        public const string SignIn = "/signin"; //TODO: A THIS SHOULD BE THE ROOT
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
        public const string Users = "/users";
        public const string Reservation = "/reservation";
        public const string Monitoring = "/monitoring";
        public const string Logs = "/logs";
        public const string Reports = "/reports";
        public const string Orders = "/orders";
        public const string OrdersPayments = "/orderspayments";
        public const string OrdersDelivery = "/ordersdelivery";

        public const string WaitingLines = "/waitinglines";

        public const string SettingsHostsComputers = "/settings/hosts/computers";
        public const string SettingsHostsComputer = "/settings/hosts/computer";
        public const string SettingsHostsEndpoints = "/settings/hosts/endpoints";
        public const string SettingsHostsEndpoint = "/settings/hosts/endpoint";
        public const string SettingsHostsControllers = "/settings/hosts/controllers";
        public const string SettingsHostsController = "/settings/hosts/controller";
        public const string SettingsHostsHostGroups = "/settings/hosts/hostgroups";
        public const string SettingsHostsHostGroup = "/settings/hosts/hostgroup";
        public const string SettingsHostsLayouts = "/settings/hosts/layouts";
        public const string SettingsHostsLayout = "/settings/hosts/layout";
    }
}
