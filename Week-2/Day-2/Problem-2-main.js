// cartApp.js
import { calculateTotal } from "./Problem-2.js";

const cart = [
    { name: "Laptop", price: 50000, quantity: 1 },
    { name: "Mouse", price: 500, quantity: 2 },
    { name: "Keyboard", price: 1500, quantity: 1 }
];

const invoiceLines = cart.map(
    item => `${item.name} x ${item.quantity} = ₹${item.price * item.quantity}`
);

const totalAmount = calculateTotal(cart);

console.log(`
INVOICE
-------
${invoiceLines.join("\n")}
-----------------------
Total Amount: INR ${totalAmount}
`);