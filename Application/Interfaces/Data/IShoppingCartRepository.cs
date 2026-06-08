using Domain.Entities;

public interface IShoppingCartRepository
{
    Task<Cart> GetByUserIdAsync(Guid userId);
    Task DeleteAsync(Guid userId);
    Task SaveAsync(Cart cart);
}