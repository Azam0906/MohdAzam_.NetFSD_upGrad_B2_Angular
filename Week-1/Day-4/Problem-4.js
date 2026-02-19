function analysisTool(n){
    // let value = n
    let result = n > 0 ? "Positive" : "Negative";
    console.log(result)
    
    // Even odd checking
    if(n%2==0){
        console.log("Even Number")
    }
    else{
        console.log("odd Number")
    }

    // printing numbers
    console.log(`Printing from 1 to ${n}`)
    for(let i = 1; i <= n; i++){
        console.log(i)
    }



}
analysisTool(23)