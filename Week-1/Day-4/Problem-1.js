function gradeEvaluation(Eng, Maths, Science){
    let result = (Eng + Maths + Science)/3
    if (result >= 75){
        console.log("Grade A")
    }
    else if (result>= 60){
        console.log("Grade B")
    }
    else if (result>= 40){
        console.log("Grade C")
    }
    else if (result< 40){
        console.log("Fail")
    }



}

gradeEvaluation(65,82,71)

