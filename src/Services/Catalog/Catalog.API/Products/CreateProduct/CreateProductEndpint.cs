namespace Catalog.API.Products.CreateProduct;
using MediatR;

public record CreateProductCommand(
    Guid Id,
    string Name,
    List<string> Categories,
    string Description,
    string ImageFile,
    decimal Price
    
) :IRequest<CreateProductResult>;
public record CreateProductResult(Guid Id);


internal class CreateProductECommandHandler:IRequestHandler<CreateProductCommand,CreateProductResult>
{  //write other commands and handlers here
    public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        // Here you would typically add logic to create the product in your database
        // For demonstration purposes, we'll just return the Id of the created product

        var result = new CreateProductResult(request.Id);
        return Task.FromResult(result);
    }

    
}