import React, { useState, useEffect } from 'react';

const CartPage = () => {
  const [cartItems, setCartItems] = useState([]);

  useEffect(() => {
    const storedCartItems = JSON.parse(localStorage.getItem('cartItems')) || [];
    setCartItems(storedCartItems);
  }, []);

  const calculateTotal = () => {
    let total = 0;
    cartItems.forEach(item => {
      total += item.price;
    });
    return total;
  };

  return (
    <div className="cart-container">
      <h2>Shopping Cart</h2>
      <ul className="cart-items-list">
        {cartItems.map((item, index) => (
          <li key={index}>
            <span>{item.name}</span>
            <span>${item.price}</span>
          </li>
        ))}
      </ul>
      <div className="cart-total">
        <span>Total:</span>
        <span>${calculateTotal()}</span>
      </div>
      <button className="checkout-button">Proceed to Checkout</button>
    </div>
  );
};

export default CartPage;
