Features

Retrieve all products
Retrieve a product by ID
Add a new product
Update an existing product
Delete a product​


Installation

Clone the repository:
git clone https://github.com/yourusername/product-api.git

2. Navigate to the project directory:
cd product-api

4. Run the application:
dotnet run

The API will be available at https://localhost:5001 or http://localhost:5000.​

📡 API Endpoints

Get All Products

URL: GET /products
Description: Retrieves a list of all products.
Response: 200 OK​

Get Product by ID
URL: GET /products/{id}
Description: Retrieves a product by its ID.

Response:
200 OK
404 Not Found if the product does not exist.​

Add a New Product

URL: POST /products
Description: Adds a new product.
Request Body:
json
Copy
Edit
{
  "id": 1,
  "name": "Sample Product",
  "price": 19.99
}
Response: 201 Created​

Update an Existing Product

URL: PUT /products/{id}
Description: Updates an existing product.
Request Body:
{
  "id": 1,
  "name": "Updated Product",
  "price": 24.99
}

Response:
204 No Content
404 Not Found if the product does not exist.​

Delete a Product

URL: DELETE /products/{id}
Description: Deletes a product by its ID.

Response:
204 No Content
404 Not Found if the product does not exist.​

The Product model is defined as follows:​

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
