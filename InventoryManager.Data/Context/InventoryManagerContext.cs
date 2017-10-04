using InventoryManager.Data.Entities;
using System.Data.Entity;

namespace InventoryManager.Data.Context
{
    public partial class InventoryManagerContext : DbContext
    {
        public InventoryManagerContext(string connString) : base(connString)
        {            
        }

        public virtual DbSet<AdjustmentReason> AdjustmentReason { get; set; }
        public virtual DbSet<AdjustmentStatus> AdjustmentStatus { get; set; }
        public virtual DbSet<BarcodeData> BarcodeData { get; set; }
        public virtual DbSet<IssueUnit> IssueUnit { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemAdjustment> ItemAdjustments { get; set; }
        public virtual DbSet<ItemIssued> ItemsIssued { get; set; }
        public virtual DbSet<ItemLocation> ItemLocations { get; set; }
        public virtual DbSet<ItemManufacturer> ItemManufacturers { get; set; }
        public virtual DbSet<ItemMaster> ItemMasters { get; set; }
        public virtual DbSet<ItemPriceHistory> ItemPriceHistory { get; set; }
        public virtual DbSet<ItemReceived> ItemsReceived { get; set; }
        public virtual DbSet<ItemReturned> ItemsReturned { get; set; }
        public virtual DbSet<ItemIssuedReceived> ItemsIssuedReceived { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderItemAdjustment> OrderItemAdjustments { get; set; }
        public virtual DbSet<OrderUnit> OrderUnits { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestItem> RequestItems { get; set; }
        public virtual DbSet<RequestStatus> RequestStatus { get; set; }
        public virtual DbSet<StockStatus> StockStatus { get; set; }
        public virtual DbSet<StockType> StockTypes { get; set; }
        public virtual DbSet<Storeroom> Storerooms { get; set; }
        public virtual DbSet<TrackingNumber> TrackingNumbers { get; set; }
        public virtual DbSet<UserStoreroom> UserStorerooms { get; set; }
        public virtual DbSet<UserWarehouse> UserWarehouses { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<WarehouseLocation> WarehouseLocations { get; set; }
        public virtual DbSet<RequestHistory> RequestHistory { get; set; }

        // Views
        public virtual DbSet<ItemMasterView> ItemMastersView { get; set; }
        public virtual DbSet<ItemView> ItemsView { get; set; }
        public virtual DbSet<ItemStoreroomView> ItemStoreroomsView { get; set; }
        public virtual DbSet<IssuancesForReturnsView> IssuancesForReturnsView { get; set; }
        public virtual DbSet<RequestItemView> RequestItemView { get; set; }
        public virtual DbSet<UserView> UserView { get; set; }
        public virtual DbSet<UserStoreroomView> UserStoreroomsView { get; set; }
        public virtual DbSet<UserWarehouseView> UserWarehousesView { get; set; }

        // Shared with EFDO
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("EFDO");

            //modelBuilder.Entity<ApplicationPermission>()
            //    .Property(e => e.PermissionKey)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ApplicationRole>()
            //    .Property(e => e.Role)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ApplicationRole>()
            //    .HasMany(e => e.ApplicationPermissions)
            //    .WithRequired(e => e.ApplicationRole)
            //    .HasForeignKey(e => e.RoleSeq);

            //modelBuilder.Entity<IssuedAsset>()
            //    .Property(e => e.AssetTag)
            //    .IsUnicode(false);

            //modelBuilder.Entity<IssuedAsset>()
            //    .Property(e => e.IssuedBy)
            //    .IsUnicode(false);

            //modelBuilder.Entity<IssuedAsset>()
            //    .Property(e => e.IssuedTo)
            //    .IsUnicode(false);

            //modelBuilder.Entity<IssuedAsset>()
            //    .Property(e => e.ReturnedBy)
            //    .IsUnicode(false);

            //modelBuilder.Entity<IssuedAsset>()
            //    .Property(e => e.ReturnedTo)
            //    .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.CommodityCode)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.SKU)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Source)
                .IsUnicode(false);

            //modelBuilder.Entity<Item>()
            //    .Property(e => e.CreatedBy)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Item>()
            //    .Property(e => e.ModifiedBy)
            //    .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.CurrentIssuePrice)
                .HasPrecision(14, 4);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemPriceHistory)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemsReceived)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.RequestItems)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemAdjustment>()
                .Property(e => e.UnitCost)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ItemAdjustment>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<ItemAdjustment>()
                .Property(e => e.Source)
                .IsUnicode(false);

            //modelBuilder.Entity<ItemAdjustment>()
            //    .Property(e => e.CreatedBy)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ItemAssetNumber>()
            //    .Property(e => e.AssetNumber)
            //    .IsUnicode(false);

            modelBuilder.Entity<ItemIssued>()
                .Property(e => e.IssuePrice)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ItemIssued>()
                .Property(e => e.Source)
                .IsUnicode(false);

            //modelBuilder.Entity<ItemIssued>()
            //    .HasMany(e => e.IssuedAssets)
            //    .WithRequired(e => e.ItemIssued)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemIssued>()
                .HasMany(e => e.ItemIssuedReceived)
                .WithRequired(e => e.ItemIssued)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemIssued>()
                .HasMany(e => e.ItemsReturned)
                .WithRequired(e => e.ItemIssued)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemLocation>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<ItemManufacturer>()
                .Property(e => e.ManufacturerName)
                .IsUnicode(false);

            modelBuilder.Entity<ItemManufacturer>()
                .Property(e => e.PartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ItemManufacturer>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<ItemMaster>()
                .Property(e => e.SKU)
                .IsUnicode(false);

            modelBuilder.Entity<ItemMaster>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ItemMaster>()
                .Property(e => e.CommodityCode)
                .IsUnicode(false);

            modelBuilder.Entity<ItemMaster>()
                .Property(e => e.StandardCost)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ItemPriceHistory>()
                .Property(e => e.ChangedFromPrice)
                .HasPrecision(14, 4);

            //modelBuilder.Entity<ItemPriceHistory>()
            //    .Property(e => e.ChangedFromUnitType)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ItemPriceHistory>()
            //    .Property(e => e.ChangedToUnitPrice)
            //    .HasPrecision(10, 4);

            //modelBuilder.Entity<ItemPriceHistory>()
            //    .Property(e => e.ChangedToUnitType)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ItemPriceHistory>()
            //    .Property(e => e.ChangedBy)
            //    .IsUnicode(false);

            modelBuilder.Entity<ItemPriceHistory>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<ItemReceived>()
                .Property(e => e.SKU)
                .IsUnicode(false);

            modelBuilder.Entity<ItemReceived>()
                .Property(e => e.ItemDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ItemReceived>()
                .Property(e => e.UnitCost)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ItemReceived>()
                .Property(e => e.UnitType)
                .IsUnicode(false);

            modelBuilder.Entity<ItemReceived>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<ItemReceived>()
                .HasMany(e => e.ItemIssuedReceived)
                .WithRequired(e => e.ItemReceived)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemReturned>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<ItemReturned>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<ItemIssuedReceived>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.PurchaseOrder)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.AdvantageDocumentID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.InvoiceTotal)
                .HasPrecision(14, 4);

            //modelBuilder.Entity<Order>()
            //    .Property(e => e.RequestedBy)
            //    .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.SKU)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.ItemDescription)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.CommodityCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.UnitMeasure)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.VendorCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.VendorName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.ManufacturerName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.ManufacturerPartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .HasMany(e => e.ItemsReceived)
                .WithRequired(e => e.OrderItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderItemAdjustment>()
                .Property(e => e.UnitCost)
                .HasPrecision(14, 4);

            modelBuilder.Entity<OrderItemAdjustment>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItemAdjustment>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItemAdjustment>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<OrderUnit>()
                .Property(e => e.Value)
                .IsUnicode(false);

            //modelBuilder.Entity<OrganizationStructure>()
            //    .HasMany(e => e.Warehouses)
            //    .WithRequired(e => e.OrganizationStructure)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Request>()
                .Property(e => e.Source)
                .IsUnicode(false);

            //modelBuilder.Entity<RequestItem>()
            //    .Property(e => e.SKU)
            //    .IsUnicode(false);

            //modelBuilder.Entity<RequestItem>()
            //    .Property(e => e.Description)
            //    .IsUnicode(false);

            modelBuilder.Entity<RequestItem>()
                .ToTable("REQUEST_ITEM");

            modelBuilder.Entity<StockStatus>()
                .Property(e => e.Value)
                .IsUnicode(false);

            //modelBuilder.Entity<StockStatus>()
            //    .HasMany(e => e.ItemMasters)
            //    .WithRequired(e => e.StockStatus)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockType>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<StockType>()
                .HasMany(e => e.ItemMasters)
                .WithRequired(e => e.StockType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Storeroom>()
                .Property(e => e.StoreroomName)
                .IsUnicode(false);

            modelBuilder.Entity<Storeroom>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TrackingNumber>()
                .Property(e => e.Source)
                .IsUnicode(false);

            //modelBuilder.Entity<UserWarehouse>()
            //    .Property(e => e.UserId)
            //    .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.WarehouseName)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Requests)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Storerooms)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.WarehouseLocations)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WarehouseLocation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<WarehouseLocation>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<WarehouseLocation>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<WarehouseLocation>()
                .HasMany(e => e.ItemLocations)
                .WithRequired(e => e.WarehouseLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WarehouseLocation>()
                .HasMany(e => e.WarehouseLocations)
                .WithOptional(e => e.WarehouseLocation2)
                .HasForeignKey(e => e.ParentSeq);

            modelBuilder.Entity<RequestHistory>()
                .Property(e => e.Source)
                .IsUnicode(false);
        }
    }
}
