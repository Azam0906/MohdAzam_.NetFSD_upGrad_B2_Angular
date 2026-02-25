// taskManager
let tasks = [];

/* ---------------- CALLBACK VERSION ---------------- */

export const addTaskCallback = (task, callback) => {
    setTimeout(() => {
        tasks.push(task);
        callback(null, tasks);
    }, 500);
};

export const deleteTaskCallback = (task, callback) => {
    setTimeout(() => {
        tasks = tasks.filter(t => t !== task);
        callback(null, tasks);
    }, 500);
};

/* ---------------- PROMISE VERSION ---------------- */

export const addTaskPromise = (task) => {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            tasks.push(task);
            resolve(tasks);
        }, 500);
    });
};

export const deleteTaskPromise = (task) => {
    return new Promise((resolve) => {
        setTimeout(() => {
            tasks = tasks.filter(t => t !== task);
            resolve(tasks);
        }, 500);
    });
};

/* ---------------- ASYNC / AWAIT VERSION ---------------- */

export const addTaskAsync = async (task) => {
    await addTaskPromise(task);
};

export const deleteTaskAsync = async (task) => {
    await deleteTaskPromise(task);
};

export const listTasks = () => {
    console.log(`
TASK LIST
---------
${tasks.length ? tasks.join("\n") : "No tasks available"}
`);
};