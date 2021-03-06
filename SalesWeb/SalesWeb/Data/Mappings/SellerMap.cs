namespace SalesWeb.Data.Mappings;

public class SellerMap : IEntityTypeConfiguration<Seller>
{
    public void Configure(EntityTypeBuilder<Seller> builder)
    {
        builder.ToTable("Seller");
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).
            IsRequired().
            HasColumnName("Name").
            HasColumnType("NVARCHAR").
            HasMaxLength(160);
        builder.Property(x => x.Email).
            IsRequired().
            HasColumnName("Email").
            HasColumnType("VARCHAR").
            HasMaxLength(160);
        builder.Property(x => x.DocumentId).
            IsRequired().HasColumnName("DocumentId").
            HasColumnType("VARCHAR").
            HasMaxLength(11);
        builder.Property(x => x.Password).
            IsRequired().
            HasColumnName("Password").
            HasColumnType("VARCHAR").
            HasMaxLength(255);
        builder.Property(x => x.BirthDate).
            IsRequired().
            HasColumnName("BirthDate").
            HasColumnType("SMALLDATETIME").
            HasMaxLength(60).
            HasDefaultValueSql("GETDATE()");
    }
}