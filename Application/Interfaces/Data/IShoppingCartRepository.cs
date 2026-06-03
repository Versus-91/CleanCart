using Domain.Entities;

public interface IShoppingCartRepository
{
    Task<ShoppingCart> GetByUserIdAsync(Guid userId);
    Task SaveAsync(ShoppingCart cart);
}