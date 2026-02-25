const products = ["Laptop", "Mobile Phone", "Headphones","Keyboard", "Mouse", "Monitor"];

const searchInput = document.getElementById("search");
const list = document.getElementById("productList");

function displayProducts(items) {
    list.innerHTML = "";

    if (items.length === 0) {
        list.innerHTML = "<li>No Results Found</li>";
        return;
    }

    items.forEach(product => {
        const li = document.createElement("li");
        li.textContent = product;
        list.appendChild(li);
    });
}

// initial load
displayProducts(products);

searchInput.addEventListener("input", function () {
    const value = searchInput.value.toLowerCase();

    const filtered = products.filter(product =>
        product.toLowerCase().includes(value)
    );

    displayProducts(filtered);
});