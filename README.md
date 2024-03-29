# PeddleRealm_2.0 (WIP)
Peddlerealm upgraded from .NET MVC 5 to .NET Core MVC.

(Original project: https://github.com/Perrym14/PeddleRealmWebApp

# PeddleRealm
A personal small-scale store web application

~~https://peddlerealmwebapp20181211061151.azurewebsites.net/~~ (**Removed from Azure for being too expensive. Deploy to domain later)**

**This app utilizes: ASP.NET MVC 5, Entity Framework 6, jQuery, Angular.JS, Visual Studio 2017, Moq, FluentAssertions, HTML5, CSS/LESS and NUnit.**

## Description
PeddleRealm is a site where the site Admin can add items up for sell (also edit/delete). Users can browse the market, filter by categories and add items to their cart (as well as remove). Whenever the user is ready, they can checkout their cart and will be prompted to input information in order to finalize their purchase. 

## Need To Do/Corner Cases
- [ ] Rewrite syncronous Controllers, APIs, etc. to be asynchronous.
- [ ] Implement repository pattern.
- [ ] Implement Unit of Work design pattern.
- [ ] Implement Inversion of Control.
- [ ] Refactor ShoppingCart class (methods should be in ShoppingCartRepository.cs)
- [ ] Validate image upload (must be jpg, jpeg, or png and file size <2mb)
- [ ] Improve checkout form
- [ ] If no items in cart, hide checkout button
- [ ] Allow admin to change item picture
- [ ] Send confirmation email with order details.
- [ ] Refactor JavaScript
  
## Upcoming Features
- [ ] Add wishlist feature
- [x] Allows users to view their orders
- [ ] Allow users to login via 3rd-party accounts (Google, Facebook, etc.)
- [ ] Allow users to change their account settings
- [ ] Display best selling items on the front page
- [ ] Add ability for items to go on sale
- [ ] Give notifications to users that an item on their wishlist is on sale

