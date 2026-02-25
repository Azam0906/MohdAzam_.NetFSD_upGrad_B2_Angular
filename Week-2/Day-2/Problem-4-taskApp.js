import {
    addTaskCallback,
    addTaskAsync,
    deleteTaskAsync,
    listTasks
} from "./Problem-4-taskManager.js";

// CALLBACK DEMO
addTaskCallback("Learn JavaScript", () => {
    listTasks();
});

// ASYNC / AWAIT DEMO
(async () => {
    await addTaskAsync("Practice ES6");
    await addTaskAsync("Revise Async JS");
    listTasks();

    await deleteTaskAsync("Practice ES6");
    listTasks();
})();