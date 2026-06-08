using Application.Interfaces.UseCases;
using Application.UseCases.RemoveItemFromCart;
using Domain.Entities;

public class RemoveItemFromCartUseCase(IShoppingCartRepository shoppingCartRepository) : IRemoveItemFromCartUseCase
{
    public async Task RemoveItemFromCartAsync(RemoveItemFromCartInput input)
    {
        Cart? cart = await shoppingCartRepository.GetByUserIdAsync(input.UserId);
        if (cart != null)
        {
            cart.RemoveItem(input.ProductId, input.Quantity);
        }
        await shoppingCartRepository.SaveAsync(cart);
    }
}