using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

class FoodConfiguration : IEntityTypeConfiguration<Food>
{
    public void Configure(EntityTypeBuilder<Food> builder)
    {
        builder.ToTable("Food");

        builder.HasKey(f => f.Id);

        builder.Property(f => f.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(f => f.Fat)
            .IsRequired();

        builder.Property(f => f.Protein)
            .IsRequired();

        builder.Property(f => f.Carbs)
            .IsRequired();

        builder.Property(f => f.Calories)
            .ValueGeneratedOnAdd();
    }
    
}