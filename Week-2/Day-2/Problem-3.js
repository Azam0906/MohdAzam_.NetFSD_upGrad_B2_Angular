const API_URL = "https://api.open-meteo.com/v1/forecast?latitude=28.61&longitude=77.20&current_weather=true";

// PROMISE VERSION
const fetchWeatherPromise = () => {
    fetch(API_URL)
        .then(response => {
            if (!response.ok) {
                throw new Error("Network response failed");
            }
            return response.json();
        })
        .then(data => {
            const weather = data.current_weather;
            console.log(`
Weather Report (Promise)
------------------------
Temperature : ${weather.temperature}°C
Wind Speed  : ${weather.windspeed} km/h
            `);
        })
        .catch(error => {
            console.error("Error:", error.message);
        });
};

// ASYNC / AWAIT VERSION
const fetchWeatherAsync = async () => {
    try {
        const response = await fetch(API_URL);
        if (!response.ok) {
            throw new Error("Failed to fetch weather data");
        }

        const data = await response.json();
        const weather = data.current_weather;

        console.log(`
Weather Report (Async/Await)
----------------------------
Temperature : ${weather.temperature}°C
Wind Speed  : ${weather.windspeed} km/h
        `);
    } catch (error) {
        console.error("Error:", error.message);
    }
};

// execution
fetchWeatherPromise();
fetchWeatherAsync();