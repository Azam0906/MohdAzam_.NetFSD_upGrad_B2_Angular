function signalSimulator(signal){
    switch (signal){
        case "red": {
            console.log("Stop");
            break;

        }
        case "yellow": {
            console.log("Get Ready");
            break;

        }
        case "green": {
            console.log("GO");
            break;

        }
        default:
            console.log("Invalid signal value");
    }
}

signalSimulator("Red")