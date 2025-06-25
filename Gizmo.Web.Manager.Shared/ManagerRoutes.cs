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
        public const string POSCloseBalance = "/posclosebalance";
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
        public const string SettingsHostsSecurityProfiles = "/settings/hosts/securityprofiles";
        public const string SettingsHostsSecurityProfile = "/settings/hosts/securityprofile";
        public const string SettingsAppsApps = "/settings/apps/apps";
        public const string SettingsAppsApp = "/settings/apps/app";
        public const string SettingsAppsAppExe = "/settings/apps/appexe";
        public const string SettingsAppsDeployment = "/settings/apps/deployment";
        public const string SettingsAppsPersonalFile = "/settings/apps/personalfile";
        public const string SettingsAppsTask = "/settings/apps/task";
        public const string SettingsAppsLicense = "/settings/apps/license";
        public const string SettingsHostsAssetTypes = "/settings/hosts/assettypes";
        public const string SettingsHostsAssetType = "/settings/hosts/assettype";
        public const string SettingsHostsTasks = "/settings/hosts/tasks";
        public const string SettingsHostsShellTriggers = "/settings/hosts/shelltriggers";

        public const string SettingsMarketingBase = "/settings/marketing";
        public const string SettingsMarketingFeeds = "/settings/marketing/feeds";
        public const string SettingsMarketingFeed = "/settings/marketing/feed";
        public const string SettingsMarketingNews = "/settings/marketing/news";
        public const string SettingsMarketingNew = "/settings/marketing/new";

        public const string SettingsShopBase = "/settings/shop";
        public const string SettingsShopStocks = "/settings/shop/stocks";
        public const string SettingsShopStock = "/settings/shop/stock";
        public const string SettingsShopProducts = "/settings/shop/products";
        public const string SettingsShopProduct = "/settings/shop/product";
        public const string SettingsShopBundles = "/settings/shop/bundles";
        public const string SettingsShopBundle = "/settings/shop/bundle";
        public const string SettingsShopProductGroups = "/settings/shop/productgroups";
        public const string SettingsShopProductGroup = "/settings/shop/productgroup";
        public const string SettingsShopStockTransactions = "/settings/shop/stocktransaction";
        public const string SettingsShopStockCounts = "/settings/shop/stockcounts";
        public const string SettingsShopStockCount = "/settings/shop/stockcount";
        public const string SettingsShopStockCountReview = "/settings/shop/stockcountreview";
        public const string SettingsShopInventories = "/settings/shop/inventories";
        public const string SettingsShopInventoriesInbound = "/settings/shop/inventories/inbound";

        public const string ConfigurationBase = "/configuration";
        public const string ConfigurationGeneral = "/configuration/general";
        public const string ConfigurationSubscription = "/configuration/subscription";
        public const string ConfigurationTaxesAndCurrency = "/configuration/taxesandcurrency";
        public const string ConfigurationBranches = "/configuration/branches";
        public const string ConfigurationBranchEdit = "/configuration/branches/edit";
        public const string ConfigurationAttributes = "/configuration/attributes";
        public const string ConfigurationAttributeEdit = "/configuration/attributes/edit";
        public const string ConfigurationCompanions = "/configuration/companions";
        public const string ConfigurationCompanionEdit = "/configuration/companions/edit";
        public const string ConfigurationRegisters = "/configuration/registers";
        public const string ConfigurationRegisterEdit = "/configuration/registers/edit";
        public const string ConfigurationOperators = "/configuration/operators";
        public const string ConfigurationOperatorEdit = "/configuration/operators/edit";
        public const string ConfigurationPermissions = "/configuration/permissions";
        public const string ConfigurationPermissionEdit = "/configuration/permissions/edit";
        public const string ConfigurationWaitingLines = "/configuration/waitinglines";
        public const string ConfigurationAgeRestrictions = "/configuration/agerestrictions";
        public const string ConfigurationVariables = "/configuration/variables";
        public const string ConfigurationVariableEdit = "/configuration/variables/edit";
        public const string ConfigurationPlugins = "/configuration/plugins";
        public const string ConfigurationAssistanceRequestTypes = "/configuration/assistancerequesttypes";
        public const string ConfigurationAssistanceRequestTypeEdit = "/configuration/assistancerequesttypes/edit";
        public const string ConfigurationNetwork = "/configuration/network";
        public const string ConfigurationBackUp = "/configuration/backup";
        public const string ConfigurationMisc = "/configuration/misc";
        public const string ConfigurationBillingProfiles = "/configuration/billingprofiles";
        public const string ConfigurationBillingProfileEdit = "/configuration/billingprofiles/edit";
        public const string ConfigurationSkinProfiles = "/configuration/skinprofiles";
        public const string ConfigurationSkinProfileEdit = "/configuration/skinprofiles/edit";
        public const string ConfigurationTimeOffers = "/configuration/timeoffers";
        public const string ConfigurationTimeOfferEdit = "/configuration/timeoffers/edit";
        public const string ConfigurationClientShell = "/configuration/clientshell";
        public const string ConfigurationCommunicationMethods = "/configuration/communicationmethods";
        public const string ConfigurationCommunicationMethodSMTPEdit = "/configuration/communicationmethods/smtp";
        public const string ConfigurationCommunicationMethodSMSEdit = "/configuration/communicationmethods/sms";
        public const string ConfigurationNotifications = "/configuration/notifications";
        public const string ConfigurationFileSystem = "/configuration/filesystem";
        public const string ConfigurationPaymentMethods = "/configuration/paymentmethods";
        public const string ConfigurationPaymentMethodEdit = "/configuration/paymentmethods/edit";
        public const string ConfigurationSelectPaymentProvider = "/configuration/selectpaymentprovider";
        public const string ConfigurationReservations = "/configuration/reservations";
        public const string ConfigurationUserAgreements = "/configuration/useragreements";
        public const string ConfigurationUserAgreementEdit = "/configuration/useragreements/edit";
        public const string ConfigurationInvoices = "/configuration/invoices";
        public const string ConfigurationScheduleReports = "/configuration/schedules/reports";
        public const string ConfigurationScheduleReportEdit = "/configuration/schedules/reports/edit";
        public const string ConfigurationTimeProducts = "/configuration/timeproducts";

        public const string DepositVoid = "/depositvoid";
    }
}
