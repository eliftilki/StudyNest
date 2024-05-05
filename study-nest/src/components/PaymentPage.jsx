import React, { useState } from 'react';


const PaymentPage = () => {
  const [formData, setFormData] = useState({
    cardNumber: '',
    cardHolderName: '',
    expiryDate: '',
    cvv: ''
  });

  const handleChange = e => {
    const { name, value } = e.target;
    setFormData({
      ...formData,
      [name]: value
    });
  };

  const handleSubmit = e => {
    e.preventDefault();
    // Ödeme tamamlama işlemleri burada yapılabilir
    console.log('Ödeme tamamlandı:', formData);
    // Ödeme işlemi tamamlandıktan sonra kullanıcıyı başka bir sayfaya yönlendirebilirsiniz
  };

  return (
    <div className="payment-container">
      <h2>Payment Information</h2>
      <form onSubmit={handleSubmit}>
        <label>
          Card Number:
          <input
            type="text"
            name="cardNumber"
            value={formData.cardNumber}
            onChange={handleChange}
            placeholder="Enter your card number"
            required
          />
        </label>
        <label>
          Cardholder Name:
          <input
            type="text"
            name="cardHolderName"
            value={formData.cardHolderName}
            onChange={handleChange}
            placeholder="Enter cardholder name"
            required
          />
        </label>
        <label>
          Expiry Date:
          <input
            type="text"
            name="expiryDate"
            value={formData.expiryDate}
            onChange={handleChange}
            placeholder="MM/YYYY"
            required
          />
        </label>
        <label>
          CVV:
          <input
            type="text"
            name="cvv"
            value={formData.cvv}
            onChange={handleChange}
            placeholder="Enter CVV"
            required
          />
        </label>
        <button type="submit">Complete Payment</button>
      </form>
    </div>
  );
};

export default PaymentPage;
