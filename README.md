<p align="center">
  <img src="/E_Commerce_Store/logo.png" alt="Logo" width="200" height="200">
</p>

<h1 align="center">E-Commerce Backend</h1>

<p align="center">
  Welcome to the E-Commerce Backend for our online shopping platform. This backend is the heart of our e-commerce application, providing essential functionality for user authentication, order management, product handling, and more.
</p>

<p align="center">
  <a href="#authentication">Authentication</a> •
  <a href="#database-initialization">Database Initialization</a> •
  <a href="#controllers">Controllers</a> •
  <a href="#authorization">Authorization</a> •
  <a href="#deployment">Deployment</a>
</p>

## Authentication :lock:

We take authentication seriously. Our backend handles authentication through a combination of Firebase Admin SDK and custom JWT tokens with refresh tokens. This ensures secure and seamless user authentication. Users can register, log in, and even sign up with their Google accounts.

## Database Initialization :floppy_disk:

To ensure a smooth shopping experience, we start with a clean slate. Our database initialization process seeds various tables, including products, categories, product attributes, users, and orders. This means we have a well-structured foundation for our e-commerce platform right from the start.

## Controllers :computer:

Our backend is organized into controllers, each responsible for specific functionality:

- **UserController**: Handles user authentication, registration, and Google sign-up.
- **OrderController**: Manages user orders and provides order-related endpoints.
- **ProductController**: Deals with product management and exposes product-related endpoints.
- **CategoryController**: Manages product categories and offers category-specific endpoints.

We've designed these controllers to be modular and efficient, making it easy to extend and enhance our e-commerce platform.

## Authorization :key:

Security is a top priority. Users must have a valid token to access our endpoints. This ensures that only authenticated users can interact with our application and its features. Unauthorized access is restricted, providing a secure shopping environment.

## Deployment :rocket:

Our backend is hosted on Azure as an App Service, ensuring reliability and scalability. Additionally, our SQL database is also hosted on Azure, allowing us to securely store and manage user data, product information, and more. This robust infrastructure ensures the smooth operation of our e-commerce platform.

Thank you for choosing our E-Commerce Backend. We're committed to delivering a seamless shopping experience for our users.

For more details, explore our codebase and feel free to reach out if you have any questions or suggestions.
