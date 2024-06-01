namespace MVCCoreCustomerApplication
{
    public static class ApplicationRoutes
    {
        public static void LoadRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("route1", "", new
            {
                controller = "Customer",
                action = "LoadCustomer"
            });
            routeBuilder.MapRoute("route2", "Customer/Add", new
            {
                controller = "Customer",
                action = "Add"
            });
            routeBuilder.MapRoute("route3", "Customer/New/{Id:int}", new
            {
                controller = "Customer",
                action = "Add"
            });
        }
    }
}
