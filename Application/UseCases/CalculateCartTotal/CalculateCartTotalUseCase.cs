using Application.Interfaces.UseCases;
using Domain.Entities;

namespace Application.UseCases.CalculateCartTotal;

public class CalculateCartTotalUseCase(IShoppingCartRepository shoppingCartRepository) : ICalculateCartTotalUseCase
{
    public async Task<decimal> CalculateTotalAsync(CalculateCartTotalInput input)
    {
        var shoppingCart = await shoppingCartRepository.GetByUserIdAsync(input.UserId);

        decimal subtotal = CalculateSubtotal(shoppingCart);
        decimal taxes = CalculateTaxes(subtotal);
        decimal total = subtotal + taxes;

        return total;
    }

    private decimal CalculateSubtotal(ShoppingCart? shoppingCart)
    {
        return shoppingCart?.Items.Sum(item => item.ProductPrice * item.Quantity) ?? 0;
    }

    private decimal CalculateTaxes(decimal subtotal)
    {
        const decimal taxRate = 0.08M;
        return subtotal * taxRate;
    }
}