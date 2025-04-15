using Minimal_APIs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

ProductServices productServices = new ProductServices();

app.MapGet("/products", () =>
{
    return productServices.GetAllProducts();
});

app.MapGet("/products/{id}", (int id) =>
{
    var product = productServices.GetProductById(id);
    if (product == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(product);
});

app.MapPost("/products", (Product product) =>
{
    productServices.AddProduct(product);
    return Results.Created($"/products/{product.Id}", product);
});

app.MapPut("/products/{id}", (int id, Product updatedProduct) =>
{
    var product = productServices.GetProductById(id);
    if (product == null)
    {
        return Results.NotFound();
    }
    productServices.UpdateProduct(id, updatedProduct);
    return Results.NoContent();
});

app.MapDelete("/products/{id}", (int id) =>
{
    var product = productServices.GetProductById(id);
    if (product == null)
    {
        return Results.NotFound();
    }

    productServices.DeleteProduct(id);
   
        return Results.NoContent();
});


app.Run();