namespace MVCCoreCustomerApplication
{
    public static class ApplicationRoutes
    {
        public static void LoadRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("route1", "Customer/Add", new
            {
                controller = "Customer",
                action = "Add"
            });
            routeBuilder.MapRoute("route2", "Customer/New/{Id:int}", new
            {
                controller = "Customer",
                action = "Add"
            });
        }
    }
}
