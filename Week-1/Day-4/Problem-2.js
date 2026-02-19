function DiscountCalculator(Amount){
    let result = Amount
    if (Amount >= 5000){
        let dis = Amount - (Amount*(1/5))
        console.log(`You got 20% Discount. Your Payable Amount is ${dis} INR`)
    }
    else if (Amount>= 3000){
         let dis = Amount - (Amount*(1/10))
        console.log(`You got 10% Discount. Your Payable Amount is ${dis} INR`)
    }
    else if (Amount< 3000){
        console.log("No Discount")
    }



}

DiscountCalculator(3000)

