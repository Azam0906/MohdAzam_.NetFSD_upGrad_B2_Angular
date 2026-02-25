const input = document.getElementById("taskInput");
const addBtn = document.getElementById("addTask");
const list = document.getElementById("taskList");

addBtn.addEventListener("click", function () {
    if (input.value === "") return;

    const li = document.createElement("li");
    li.innerHTML = `
        <span>${input.value}</span>
        <button class="delete">X</button>
    `;
    list.appendChild(li);
    input.value = "";
});

// EVENT DELEGATION
list.addEventListener("click", function (e) {

    if (e.target.tagName === "SPAN") {
        e.target.classList.toggle("completed");
    }

    if (e.target.classList.contains("delete")) {
        e.target.parentElement.remove();
    }
});