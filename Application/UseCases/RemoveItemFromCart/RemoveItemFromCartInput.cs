namespace Application.UseCases.RemoveItemFromCart;

public record RemoveItemFromCartInput(Guid UserId,Guid ProductId,int Quantity);