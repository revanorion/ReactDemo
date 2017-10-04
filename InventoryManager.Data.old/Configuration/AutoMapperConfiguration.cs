using AutoMapper;

namespace InventoryManager.Data.Configuration
{
    public static class AutoMapperConfiguration
    {
        private static bool isConfigured;
        public static IMapper Mapper;
        public static IConfigurationProvider Provider;

        public static void Configure()
        {
            if (isConfigured) return;

            Provider = new MapperConfiguration(cfg =>
            {
                // Tables
                cfg.CreateMap<Entities.AdjustmentStatus, DTOs.AdjustmentStatus>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.AdjustmentReason, DTOs.AdjustmentReason>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.BarcodeData, DTOs.BarcodeData>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.IssueUnit, DTOs.IssueUnit>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.Item, DTOs.Item>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.ItemAdjustment, DTOs.ItemAdjustment>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.ItemIssued, DTOs.ItemIssued>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.ItemIssuedReceived, DTOs.ItemIssuedReceived>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.ItemLocation, DTOs.ItemLocation>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.ItemManufacturer, DTOs.ItemManufacturer>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.ItemMaster, DTOs.ItemMaster>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.ItemPriceHistory, DTOs.ItemPriceHistory>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.ItemReceived, DTOs.ItemReceived>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.ItemReturned, DTOs.ItemReturned>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.Order, DTOs.Order>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.OrderItem, DTOs.OrderItem>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.OrderItemAdjustment, DTOs.OrderItemAdjustment>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.OrderUnit, DTOs.OrderUnit>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.Request, DTOs.Request>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.RequestHistory, DTOs.RequestHistory>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.RequestItem, DTOs.RequestItem>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.RequestStatus, DTOs.RequestStatus>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.StockStatus, DTOs.StockStatus>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.StockType, DTOs.StockType>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.Storeroom, DTOs.Storeroom>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.TrackingNumber, DTOs.TrackingNumber>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.UserStoreroom, DTOs.UserStoreroom>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.UserWarehouse, DTOs.UserWarehouse>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.Warehouse, DTOs.Warehouse>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.WarehouseLocation, DTOs.WarehouseLocation>().MaxDepth(1).ReverseMap();


                cfg.CreateMap<Entities.Request, Entities.Request>().ForMember(x => x.RequestItems, opt=>opt.Ignore());


                // Views
                cfg.CreateMap<Entities.ItemMasterView, DTOs.ItemMasterView>();
                cfg.CreateMap<Entities.ItemView, DTOs.ItemView>();
                cfg.CreateMap<Entities.ItemStoreroomView, DTOs.ItemStoreroomView>();
                cfg.CreateMap<Entities.IssuancesForReturnsView, DTOs.IssuancesForReturnsView>();
                cfg.CreateMap<Entities.RequestItemView, DTOs.RequestItemView>();
                cfg.CreateMap<Entities.UserView, DTOs.UserView>();
                cfg.CreateMap<Entities.UserStoreroomView, DTOs.UserStoreroomView>();
                cfg.CreateMap<Entities.UserWarehouseView, DTOs.UserWarehouseView>();

                // Shared with EFDO
                cfg.CreateMap<Entities.Department, DTOs.Department>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.Division, DTOs.Division>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.Region, DTOs.Region>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.Section, DTOs.Section>().MaxDepth(1).ReverseMap();
                cfg.CreateMap<Entities.WorkOrder, DTOs.WorkOrder>().MaxDepth(1).ReverseMap();

            });

            Mapper = Provider.CreateMapper();
            isConfigured = true;
        }
    }
}
